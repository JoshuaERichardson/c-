using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using random_password.Models;
using Microsoft.AspNetCore.Http;

namespace random_password.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string chars="ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var randomChars = new char[14];
            var random = new Random();
            for (int i = 0; i<randomChars.Length; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(randomChars);
            ViewBag.finalString = finalString;
            if(HttpContext.Session.GetInt32("Seeing") == null)
            {
            int? IntVariable = HttpContext.Session.GetInt32("Seeing");
            HttpContext.Session.SetInt32("Seeing", 0);
            ViewBag.NewVar = IntVariable;
            }

            return View();
        }
        
        public IActionResult NewRoute()
        {
            int? IntVariable = HttpContext.Session.GetInt32("Seeing");
            HttpContext.Session.SetInt32("Seeing", (int)IntVariable + 1);
            ViewBag.NewVar = IntVariable;
            string chars="ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var randomChars = new char[14];
            var random = new Random();
            for (int i = 0; i<randomChars.Length; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(randomChars);
            ViewBag.finalString = finalString;        
            return View("Index");
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
