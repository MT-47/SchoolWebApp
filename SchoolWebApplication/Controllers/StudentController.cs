using Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebApplication.Filters;
using Task_001;

namespace SchoolWebApplication.Controllers
{
    [Authorize]
    [NoCacheFilter]
    public class StudentController : Controller
    {
        IEntityRepo<Student> studentrepo;
        IEntityRepo<Department> deptrepo;
        UserManager<ApplicationUser> _userManager;

        public StudentController(
            IEntityRepo<Department> _deptrepo,
            IEntityRepo<Student> _studentRepo,
            UserManager<ApplicationUser> userManager)
        {
            studentrepo = _studentRepo;
            deptrepo = _deptrepo;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var model = studentrepo.GetAll();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var model = studentrepo.GetById(id.Value);
            return (model == null) ? NotFound() : View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.Departments = deptrepo.GetAll();
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid) 
            {
                ViewBag.Departments = deptrepo.GetAll();
                return View(student);
            }
            studentrepo.Add(student);
            studentrepo.Save();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();

            if (!User.IsInRole("Admin"))
            {
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser.StudentId != id)
                    return Forbid();
            }

            ViewBag.Departments = deptrepo.GetAll();
            var model = studentrepo.GetById(id.Value);
            return (model == null) ? NotFound() : View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student student, int id)
        {
            if (!User.IsInRole("Admin"))
            {
                var currentUser = await _userManager.GetUserAsync(User);
                if (currentUser.StudentId != id)
                    return Forbid();
            }

            student.Id = id;
            studentrepo.Update(student);
            studentrepo.Save();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var student = studentrepo.GetById(id);
            if (student == null)
                return NotFound();
            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteConfirmed(int id)
        {
            studentrepo.Delete(id);
            studentrepo.Save();
            return RedirectToAction("Index");
        }
    }
}
