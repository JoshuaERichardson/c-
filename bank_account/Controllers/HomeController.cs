using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_and_reg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace login_and_reg.Controllers
{
    public class HomeController : Controller
    {
        // setup
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        
        // Register new user
        public IActionResult Index()
        {
            return View();
        }
        // add new user to database
        [HttpPost("/processregister")]
        public IActionResult ProcessRegister(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("success");
            }
            else
            {
                // If we found a modelstate invalidity
                return View("Index");
            }
        }

        // view user login
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        // process user login
        [HttpPost("login")]
        public IActionResult ProcessLogin(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Password", "Password does not match Email");
                    return View("Login");
                }
            }
            return RedirectToAction("Success");
        }

        // View logged in page
        [HttpGet("success")]
        public IActionResult Success()
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
