using Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolWebApplication.Models;
using Task_001;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IEntityRepo<Student> _studentRepo;

    public AccountController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IEntityRepo<Student> studentRepo)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _studentRepo = studentRepo;
    }

    public IActionResult Register() => View();

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var student = new Student
        {
            Name = model.Name,
            Age = model.Age,
            Email = model.Email,
        };
        _studentRepo.Add(student);
        _studentRepo.Save();

        var user = new ApplicationUser
        {
            UserName = model.Email,
            Email = model.Email,
            StudentId = student.Id
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);
            return View(model);
        }

        await _userManager.AddToRoleAsync(user, "Student");

        return RedirectToAction("Login");
    }

    public IActionResult CheckEmail(string Email)
    {
        var student = _studentRepo.Find(s => s.Email == Email).FirstOrDefault();
        return Json(student == null ? true : "This Email is already used.");
    }

    public IActionResult Login() => View();

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var result = await _signInManager.PasswordSignInAsync(
            model.Email,        // Username
            model.Password,     // Password
            false,              // RememberMe
            false               // LockoutOnFailure
        );

        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Invalid email or password.");
            return View(model);
        }

        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }
}