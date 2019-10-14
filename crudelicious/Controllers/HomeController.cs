using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crudelicious.Models;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // RENDER HOMEPAGE
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            ViewBag.AllDishes = AllDishes;
            return View();
        }
        // RENDER ADD NEW PAGE

        [HttpGet("new")]
        public IActionResult AddDish()
        {
            
            return View();
        }
       
       // ADD NEW DISH
        [HttpPost("/new")]
        public IActionResult ProcessAddDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine(dish);
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddDish");
            }
        }

        //  RENDER INDIVIDUAL DISH
        [HttpGet("{DishId}")]
        public IActionResult ViewDish(int DishId)
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            Dish MyDish = AllDishes.FirstOrDefault(Dish => Dish.DishId == DishId);
            ViewBag.MyDish = MyDish;
            string EditMeId = MyDish.DishId.ToString();
            string EditMe = "/edit/" + EditMeId;
            ViewBag.EditMe = EditMe;
            return View();
        }
        
        //   REMOVE ONE DISH
        [HttpPost("{DishId}")]
        public IActionResult DeleteDish(int DishId)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == DishId);
            dbContext.Dishes.Remove(RetrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // RENDER ONE EDIT
        [HttpGet("edit/{DishId}")]
        public IActionResult EditDish(int DishId)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dish => dish.DishId == DishId);
            ViewBag.RetrievedDish = RetrievedDish;
            return View();
        }

        // EDIT ONE DISH
        [HttpPost("edit/{DishId}")]
        public IActionResult ProcessEditDish(int DishId, Dish dish)
        {
            Dish RetrievedDish = dbContext.Dishes.SingleOrDefault(dishmoo => dishmoo.DishId == DishId);
            if(ModelState.IsValid)
            {
                RetrievedDish.ChefName = dish.ChefName;
                RetrievedDish.DishName = dish.DishName;
                RetrievedDish.Calories = dish.Calories;
                RetrievedDish.Tastiness = dish.Tastiness
                RetrievedDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("edit/{DishId}");
            }
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
