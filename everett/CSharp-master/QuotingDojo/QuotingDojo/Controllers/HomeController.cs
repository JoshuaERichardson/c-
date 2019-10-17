using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("quotes")]
        public IActionResult CreateQuote(Quote newQuote)
        {
            if (ModelState.IsValid)
            {
                string query = $"INSERT INTO Quote (creator, content) VALUES ('{newQuote.Creator}', '{newQuote.Content}')";
                DbConnector.Execute(query);
                return RedirectToAction("GetQuotes");
            }
            return View("Index");
        }

        [HttpGet("quotes")]
        public IActionResult GetQuotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quote ORDER BY created_at DESC");
            ViewBag.Quote = AllQuotes;
            return View("Quotes");
        }
    }
}