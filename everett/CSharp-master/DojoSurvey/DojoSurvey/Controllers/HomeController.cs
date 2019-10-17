using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string FavLanguage, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.FavLang = FavLanguage;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}