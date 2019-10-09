using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting_dojo.Models;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("ProcessForm")]
        public IActionResult ProcessForm(Quotes Quotes)
        {
            if(ModelState.IsValid)
            {
                
                string query = $"INSERT INTO Quotes (Name, Quote) VALUES ('{Quotes.Name}','{Quotes.Quote}')";
                System.Console.WriteLine(query);
                DbConnector.Execute(query);
                return RedirectToAction("/quotes");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Quotes")]
        public IActionResult Quotes()
        {
            return View();
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
