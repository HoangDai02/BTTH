using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public string Index()
        {
            return "sin chao day la dai";
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
// GET: /hoang quoc dai 202105016/ 
// Nhiệm vụ của View: Cung cấp giao diện người dùng (HTML) bằng C#/