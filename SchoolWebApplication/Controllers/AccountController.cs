using Helper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SchoolWebApplication.Models;
using System.Security.Claims;
using Task_001;

namespace SchoolWebApplication.Controllers
{
    public class AccountController : Controller
    {
        IEntityRepo<Student> studentrepo;
        UserManager<ApplicationUser> usermanager;
        SignInManager<ApplicationUser> signinmanager;
        public AccountController(IEntityRepo<Student> _studentRepo, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager) 
        {
            studentrepo = _studentRepo;
            usermanager = _userManager;
            signinmanager = _signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email,
            };
            var res = await usermanager.CreateAsync(user, model.Password);
            if (res.Succeeded) 
            {
                await usermanager.AddToRoleAsync(user, "Student");
                return RedirectToAction("index", "home");
            }
            return RedirectToAction("Login");
        }

        public IActionResult CheckEmail(string Email)
        {
            var student = studentrepo.Find(s => s.Email == Email).FirstOrDefault();
            return Json(student == null ? true : "This Email is already used.");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var student = studentrepo.Find(s => s.Email == model.Email).FirstOrDefault();

            if (student == null)
            {
                ModelState.AddModelError("Email", "This email is not registered.");
                return View(model);
            }

            if (student.Password != model.Password)
            {
                ModelState.AddModelError("Password", "Incorrect password.");
                return View(model);
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, student.Name),
                    new Claim(ClaimTypes.Email, student.Email),
                    new Claim(ClaimTypes.Role, "Student")
                };

            var ci = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var cp = new ClaimsPrincipal(ci);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, cp);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
