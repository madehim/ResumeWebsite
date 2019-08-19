using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResumeWebSite.Models.Admin;
using ResumeWebSite.Models.Project;
using ResumeData.Models;
using ResumeData;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace ResumeWebSite.Controllers
{
    public class AdminController : Controller
    {
        private IUser _user;
        private IProject _project;

        public AdminController(IUser user, IProject project)
        {
            _user = user;
            _project = project;
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return LocalRedirect("/Admin/Index");
            RegLink();

            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            if (_user.GetAll().Count() > 0)
                return LocalRedirect("/Admin/Login");
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index(int id)
        {
            if (id != 0)
            {
                var project = _project.Get(id);
                if (project != null)
                {
                    string pics = "";
                    foreach (var pic in project.Pictures)
                    {
                        pics += pic.Link + ",";
                    }
                    string tags = "";
                    foreach (var tag in project.Tags)
                    {
                        tags += tag.TagName + ",";
                    }

                    var model = new ProjectAdminModel
                    {
                        Id = project.Id,
                        ProjectName = project.ProjectName,
                        ProjectDescription = project.ProjectDescription,
                        ProjectGitHubLink = project.ProjectGitHubLink,
                        Pictures = pics,
                        Tags = tags
                    };

                    return View(model);
                }
            }
            return View();

        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(ProjectAdminModel projectAdminModel)
        {
            _project.Add(ToResumeDataProject(projectAdminModel, true));
            return LocalRedirect("/admin");
        }
        [Authorize]
        [HttpPost]
        public IActionResult Change(ProjectAdminModel projectAdminModel)
        {
            _project.Change(ToResumeDataProject(projectAdminModel, false));
            return LocalRedirect("/admin/index/" + projectAdminModel.Id);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Delete(ProjectAdminModel projectAdminModel)
        {
            _project.Remove(projectAdminModel.Id);
            return LocalRedirect("/admin");
        }

        [Authorize]
        [HttpGet]
        public IActionResult AllProjects()
        {
            var all = _project.GetAll().Select(x => new ProjectDetailModel
            {
                Id = x.Id,
                ProjectName = x.ProjectName
            });

            var model = new ProjectIndexModel
            {
                Projects = all
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _user.GetByLogin(model.Login);
                if (user != null)
                {
                    if (_user.Login(user, model.Password))
                    {
                        await AuthenticateAsync(model.Login); // аутентификация
                        return RedirectToAction("Index", "Admin");
                    }
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            RegLink();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(AdminRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _user.GetByLogin(model.Login);
                if (user == null)
                    user = _user.GetAll().FirstOrDefault(x => x.Email == model.Email);

                if (user == null)
                {
                    _user.Registration(model.Login, model.Email, model.Password);
                    await AuthenticateAsync(model.Login); // аутентификация
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин или почта");
            }
            return View(model);
        }

        private async Task AuthenticateAsync(string login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (Request.Headers["Referer"].ToString() != null)
            {
                string tmp = Request.Headers["Referer"].ToString();
                return Redirect(tmp);
            }
            return Redirect("/Home");
        }

        private void RegLink()
        {
            ViewBag.RegLink = false;
            if (_user.GetAll().Count() == 0)
                ViewBag.RegLink = true;
        }

        private Project ToResumeDataProject(ProjectAdminModel projectAdminModel, bool isAdd)
        {
            string[] tagsFromPrAd = projectAdminModel.Tags.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            string[] picsFromPrAd = projectAdminModel.Pictures.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            List<Tag> tags = new List<Tag>(tagsFromPrAd.Length);
            List<Picture> pics = new List<Picture>(picsFromPrAd.Length);

            if (isAdd)
            {
                for (int i = 0; i < tagsFromPrAd.Length; i++)
                {
                    Tag tag = new Tag { TagName = tagsFromPrAd[i] };
                    tags.Add(tag);
                }
                for (int i = 0; i < picsFromPrAd.Length; i++)
                {
                    Picture pic = new Picture { Link = picsFromPrAd[i] };
                    pics.Add(pic);
                }
            }
            else
            {
                Project currentProject = _project.Get(projectAdminModel.Id);
                for (int i = 0; i < tagsFromPrAd.Length; i++)
                {
                    if (currentProject.Tags.Any(x => x.TagName == tagsFromPrAd[i]))
                    {
                        Tag tag = currentProject.Tags.FirstOrDefault(x => x.TagName == tagsFromPrAd[i]);
                        tags.Add(tag);
                    }
                    else
                    {
                        Tag tag = new Tag { TagName = tagsFromPrAd[i] };
                        tags.Add(tag);
                    }
                }

                for (int i = 0; i < picsFromPrAd.Length; i++)
                {
                    if (currentProject.Pictures.Any(x => x.Link == picsFromPrAd[i]))
                    {
                        Picture pic = currentProject.Pictures.FirstOrDefault(x => x.Link == picsFromPrAd[i]);
                        pics.Add(pic);
                    }
                    else
                    {
                        Picture pic = new Picture
                        {
                            Link = picsFromPrAd[i]
                        };
                        pics.Add(pic);
                    }
                }

                currentProject.Tags = tags;
                currentProject.Pictures = pics;
                currentProject.ProjectName = projectAdminModel.ProjectName;
                currentProject.ProjectGitHubLink = projectAdminModel.ProjectGitHubLink;
                currentProject.ProjectDescription = projectAdminModel.ProjectDescription;
                return currentProject;
            }

            Project project = new Project
            {
                Id = projectAdminModel.Id,
                ProjectName = projectAdminModel.ProjectName,
                ProjectDescription = projectAdminModel.ProjectDescription,
                ProjectGitHubLink = projectAdminModel.ProjectGitHubLink,
                Pictures = pics,
                Tags = tags
            };
            return project;
        }
    }
}
