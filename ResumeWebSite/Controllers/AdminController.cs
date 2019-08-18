using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResumeWebSite.Models.Admin;
using ResumeData;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ResumeWebSite.Controllers
{
    public class AdminController : Controller
    {
        private IUser _user;

        public AdminController(IUser user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return LocalRedirect("/Admin/Index");
            ViewBag.RegLink = false;
            if (_user.GetAll().Count() == 0)
                ViewBag.RegLink = true;

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


        private string Hashing(byte[] salt, string password)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 10000,
                        numBytesRequested: 256 / 8));
        }

    }
}
