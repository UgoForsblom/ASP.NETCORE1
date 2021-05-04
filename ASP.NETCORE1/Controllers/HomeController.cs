using Microsoft.AspNetCore.Mvc;
using ASP.NETCORE1.Models;

namespace ASP.NETCORE1.Controllers
{
    public class HomeController : Controller
    {
     //IMessagesService_messagesService = new FileMessagesService();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Doctor()
        
        {
            return View("Doctor");
        }
        [HttpPost]
        public IActionResult FeverCheck(int temperature)
        {
         

            return View();





        }

    }

}
