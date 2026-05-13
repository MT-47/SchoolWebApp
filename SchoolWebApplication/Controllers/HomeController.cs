using Microsoft.AspNetCore.Mvc;
using SchoolWebApplication.Filters;
using SchoolWebApplication.Models;
using System.Diagnostics;

namespace SchoolWebApplication.Controllers
{
    [NoCacheFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
