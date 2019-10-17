using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;


namespace RandomPasscode.Controllers.HomeController
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Password = new PasswordGen().GetPassword(14);
            ViewBag.Count = PasswordGen.GetCount();
            return View();
        }
        [HttpGet("/password")]
        public JsonResult Password()
        {
            return Json(new PasswordGen().GetPassword(14));
        }
    }
}