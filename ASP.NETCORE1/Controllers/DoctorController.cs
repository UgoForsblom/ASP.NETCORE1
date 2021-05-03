using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE1.Models;

namespace ASP.NETCORE1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int temperature)
        {
            System.Diagnostics.Debug.WriteLine(temperature);
            if (temperature > 39)
            {
                ViewBag.MyMessage = "High Fever";
                return View();


            }
            else if (temperature <= 10)
            {
                ViewBag.MyMessage = "Hyportemia";
               

            }
            else
            {
                ViewBag.MyMessage = "No fever";
                
            }

            return View();
        }
    }
}
