using Helper;
using Microsoft.AspNetCore.Authorization;
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

        public StudentController(IEntityRepo<Department> _deptrepo, IEntityRepo<Student> _studentRepo)
        {
            studentrepo = _studentRepo;
            deptrepo = _deptrepo;
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

        public IActionResult Create()
        {
            ViewBag.Departments = deptrepo.GetAll();
            return View();
        }
        [HttpPost]
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

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            ViewBag.Departments = deptrepo.GetAll();
            var model = studentrepo.GetById(id.Value);
            return (model == null) ? NotFound() : View(model);
        }
        [HttpPost]
        public IActionResult Edit(Student student, int id)
        {
            if (student == null)
                return BadRequest();
            student.Id = id;
            studentrepo.Update(student);
            studentrepo.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = studentrepo.GetById(id);
            if (student == null)
                return NotFound();
            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            studentrepo.Delete(id);
            studentrepo.Save();
            return RedirectToAction("Index");
        }
    }
}
