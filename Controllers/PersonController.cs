using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstWebMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = " Xin chào " + ps.PersonId + "-" + ps.FullName + "-" +  ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}
public async task<IActionResult> Upload()
{
    return View();
}
[Httpost]
[ValidateAntiForgeryToken]
public async task<IActionResult> Upload(IFormFile file)
{
    if (file!=null)
    {
        string fileExtension = Path.GetExtension(file.Filename);
        if (fileExtension !=".xls"&& fileExtension !=".xlsx")
        {
            ModelStateDictionary.AddmodelError("","Please choose excel file to upload!");
        }
        else
        {
            var fileName = DateTime.Now.ToShortTimeString()+fileExtension;
            var fileName = Path.Combine(Directory.GetCurrentDirectory()+"/Uploads/excels", fileName);
            var filelocation = new FileInfo(filePath).ToString();
            using (var stream = new FileStream(filepath,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
    }
    return View();

}