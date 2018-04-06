using System.Diagnostics;
using hello_world_git.Models;
using Microsoft.AspNetCore.Mvc;

namespace hello_world_git.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
