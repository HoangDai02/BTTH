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
// GET: /hoang quoc dai 2021050165/ 