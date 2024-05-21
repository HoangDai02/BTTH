using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FirstWebMVC.Models;
namespace FirstWebMVC.Controllers
{
    public class SinhVienController : Controller
    {
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index( SinhVien sv)
        {
        string strOutput = sv.HoTen + " - " + sv.Address +" - " + sv.Age + " - " +  sv.Phone;
        @ViewBag.infoSinhVien = strOutput;
        return View();
        }
    }
}