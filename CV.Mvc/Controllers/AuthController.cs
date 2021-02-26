using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using CV.Business.Interfaces;
using CV.Mvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace CV.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAppUserService _appUserService;

        public AuthController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Login()
        {
            return View(new AppUserLoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginModel appUserLoginModel)
        {
            if (ModelState.IsValid)
            {
                var check = _appUserService.Authenticate(appUserLoginModel.UserName, appUserLoginModel.Password);

                if (check)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, appUserLoginModel.UserName)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = appUserLoginModel.RememberMe
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToAction("Index", "Home", new {@area = "Admin"});
                }

                ModelState.AddModelError("", "Username or password is incorrect");
            }

            return View(appUserLoginModel);
        }
    }
}