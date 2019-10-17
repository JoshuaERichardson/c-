using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;



namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
    {
        
            ViewBag.Fullness = Dojoachi.Fullness;
            ViewBag.Happiness = Dojoachi.Happiness;
            ViewBag.Meals = Dojoachi.Meals;
            ViewBag.Energy = Dojoachi.Energy;
        ViewBag.Photo = Dojoachi.Photo;
            return View();
        }
        [HttpPost("GoAchi")]
        public IActionResult GoAchi(string activity)
        {
            
            switch (activity)
            {
                case "sleep":
                    Dojoachi.Sleep();
                    break;
                case "feed":
                    Dojoachi.Feed();
                    break;
                case "play":
                    Dojoachi.Play();
                    break;
                case "work":
                    Dojoachi.Work();
                    break;
            }
            return RedirectToAction("Index");
        }


      
    }
}
       