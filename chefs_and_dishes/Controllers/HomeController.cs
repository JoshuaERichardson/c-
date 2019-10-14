using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefs_and_dishes.Models;
using Microsoft.EntityFrameworkCore;



namespace chefs_and_dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        // View Chef Roster
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }

        // View Dish Roster
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> dishesWithChef = dbContext.Dishes
                .Include(dish => dish.Creator)
                .ToList();
            return View(dishesWithChef);
        }
        // View Add Chef
        [HttpGet("new")]
        public IActionResult NewChef()
        {

            return View();
        }
        // Process Add a chef
        [HttpPost("processNewChef")]
        public IActionResult ProcessNewChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                if(newChef.DOB > DateTime.Now)
                {
                    ModelState.AddModelError("DOB", "Date of Birth cannot be a future date you seer");
                    return View("NewChef");
                }
                System.Console.WriteLine("The newChef info looks like", newChef);
                dbContext.Add(newChef);
                dbContext.SaveChanges();
            }
            return View("NewChef");
        }
        // View Add Dish
        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }
        // Add a Dish
        [HttpPost("processNewDish")]
        public IActionResult ProcessNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View("NewDish");
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
