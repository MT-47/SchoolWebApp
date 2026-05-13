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
    public class DepartmentController : Controller
    {
        IEntityRepo<Department> deptrepo;

        public DepartmentController(IEntityRepo<Department> _deptrepo) 
        {
            deptrepo = _deptrepo;
        }

        public IActionResult Index()
        {
            var model = deptrepo.GetAll();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();

            var model = deptrepo.GetById(id.Value);
            return (model == null)? NotFound() : View(model);
        }
        
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Department dept)
        {
            if (!ModelState.IsValid) 
                return View(dept);
            deptrepo.Add(dept);
            deptrepo.Save();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            var model = deptrepo.GetById(id.Value);
            return (model == null) ? NotFound() : View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Department dept,int id)
        {
            if (dept == null)
                return BadRequest();
            dept.DeptId = id;
            deptrepo.Update(dept);
            deptrepo.Save();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id) 
        {
            var dept = deptrepo.GetById(id);
            if (dept == null)
                return NotFound();
            return View(dept);
        }
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteConfirmed(int id)
        {
            deptrepo.Delete(id);
            deptrepo.Save();
            return RedirectToAction("Index");
        }

    }
}
