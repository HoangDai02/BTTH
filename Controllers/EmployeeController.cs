using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
         // GET: /employee/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee ps)
        {
            string strOutput = " Xin chào " + ps.PersonId + "-" + ps.FullName + "-" +  ps.Address + "-" + ps.EmployeeId + "-" + ps.Age;
            ViewBag.infoEmployee = strOutput;
            return View();
        }
    }
}