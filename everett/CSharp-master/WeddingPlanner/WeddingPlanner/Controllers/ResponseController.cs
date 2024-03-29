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
    [Route("response")]
    public class ResponseController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private MyContext dbContext;
        public ResponseController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("rsvp/{weddingId}")]
        public IActionResult RSVP(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");


            Response newResponse = new Response()
            {
                WeddingId = weddingId,
                UserId = (int)UserSession
            };
            dbContext.Responses.Add(newResponse);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }

        [HttpGet("unrsvp/{weddingId}")]
        public IActionResult UnRSVP(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");
            

            Response toDelete = dbContext.Responses.FirstOrDefault(r => r.WeddingId == weddingId && r.UserId == UserSession);
            

            if (toDelete == null)
                return RedirectToAction("Dashboard", "Wedding");

            dbContext.Responses.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }
    }
}