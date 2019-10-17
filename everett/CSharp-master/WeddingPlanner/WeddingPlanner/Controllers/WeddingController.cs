using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    [Route("wedding")]
    public class WeddingController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private MyContext dbContext;
        public WeddingController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {

            if (UserSession == null)
                return RedirectToAction("Index", "Home");


            var AllWeddings = dbContext.Weddings
                .Include(w => w.Responses)
                .OrderByDescending(w => w.Date)
                .ToList();
                
            ViewBag.UserId = UserSession;
            return View(AllWeddings);
        }

        [HttpGet("{weddingId}")]
        public IActionResult Show(int weddingId)
        {
            var thisWedding = dbContext.Weddings
            .Include(w => w.Responses)
            .ThenInclude(r => r.Guest)
            .FirstOrDefault(w => w.WeddingId == weddingId);
            return View(thisWedding);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Wedding newWedding)
        {
            if (UserSession == null)
                    return RedirectToAction("Index", "Home");
            if (ModelState.IsValid)
            {   

                newWedding.UserId = (int)UserSession;
                dbContext.Weddings.Add(newWedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("New");
        }

        [HttpGet("delete")]
        public IActionResult Delete(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");

            Wedding toDelete = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            
            if (toDelete == null)
                return RedirectToAction("Dashboard");

            if (toDelete.UserId != UserSession)
                return RedirectToAction("Dashboard");
            
            dbContext.Weddings.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}