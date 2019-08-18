using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResumeWebSite.Models.Admin;
using ResumeWebSite.Models.Project;
using ResumeData;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public IActionResult Index()
        {
            return View();
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
    }
}
