using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wedding_planner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace wedding_planner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            // Clear the session in case we got here somehow!
            HttpContext.Session.Clear();
            return View();
        }


        [HttpPost("processNewUser")]
        public IActionResult ProcessNewUser(User newUser)
        {
            // Check to see if contain a FirstName.  If not look at the login
            if(newUser.FirstName !=  null || newUser.LastName != null)
            {
                //Start with if everything was entered correctly
                if(ModelState.IsValid)
                    // If the email is already used throw an error
                    {
                    // First grab all the users
                        List<User> AllUsers = dbContext.Users.ToList();
                        // Now see if the email in the form already exists in AllUsers
                        foreach(var user in AllUsers)
                        {
                            if (user.Email == newUser.Email)
                            {
                                ModelState.AddModelError("Email", "Email already in use!");
                                return View("Index");
                            }
                        }
                        // Ok the email is unique and there are no errors.  Let's Encrypt their password!
                        PasswordHasher<User> Hasher = new PasswordHasher<User>();
                        newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                        // Now add the user
                        dbContext.Add(newUser);
                        // Now Save the damn changes!
                        dbContext.SaveChanges();
                        // Now add them into session before redirecting them to the dashboard.
                        HttpContext.Session.SetString("UserEmail", newUser.Email);
                        return RedirectToAction("Dashboard");
                    }
            }
                return View("Index");
        }
        
        
        [HttpPost("processLogin")]
        public IActionResult ProcessLogin(User oldUser)
        {
            // Grab all users so that we can compare
            List<User> AllUsers = dbContext.Users.ToList();
            foreach(var user in AllUsers)
                {
                    // check to ensure the email exists
                    if(user.Email == oldUser.CheckEmail)
                    {
                        // Now check the password
                        var hasher = new PasswordHasher<User>();
                        PasswordVerificationResult result = hasher.VerifyHashedPassword(oldUser, user.Password, oldUser.CheckPassword);
                        // Result can be compared to 0 for failure
                        if(result == 0)
                        {
                            ModelState.AddModelError("Password", "Email does not match");
                        }
                        // Now we know the password matched and the email existed.  Add them to session and redirect
                        HttpContext.Session.SetString("UserEmail", oldUser.CheckEmail);
                        return RedirectToAction("Dashboard");
                    }
                }
            return View("Index");
        }


















        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // First make sure there is a user in session.
            string VerifyLoggedIn = HttpContext.Session.GetString("UserEmail");
            if(VerifyLoggedIn != null)
            {
            // Grab all weddings so we can loop through
            ViewBag.AllWeddings = dbContext.Weddings
                .Include(wedding => wedding.WeddingToJoin)
                .ThenInclude(join => join.User);
            //Viewbag VerifyLoggedIn to CRUD
            ViewBag.VerifyLoggedIn = VerifyLoggedIn;
            //Grab the logged in user's id to figure out if he or she is on the guestlist
            User GrabbedUser = dbContext.Users.FirstOrDefault(user => user.Email == VerifyLoggedIn);
            ViewBag.GrabbedUser = GrabbedUser;
            return View();
            }
            // Kick the user out if there is no UserEmail Session available
            return View("Index");
        }


        [HttpGet("processDeleteWedding/{HLinkWeddingId}")]
        public IActionResult ProcessDeleteWedding(int HLinkWeddingId)
        {
            // Retrieve the one wedding
            Wedding RetrievedWedding = dbContext.Weddings.SingleOrDefault(wedding => wedding.WeddingId == HLinkWeddingId);
            // Now remove it
            dbContext.Weddings.Remove(RetrievedWedding);
            // and of course save
            dbContext.SaveChanges();
            // Send back to dashboard
            return Redirect("/dashboard");
        }
        [HttpGet("processAddUserToWedding/{weddingId}/{userEmail}")]
        public IActionResult ProcessAddUserToWedding(int weddingId, string userEmail)
        {
            //  link the tables based on the one wedding
            var RetrievedWedding = dbContext.Weddings
                .Include(join => join.WeddingToJoin)
                .ThenInclude(join => join.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);
            // Grab the UserId
            var GrabbedUser = dbContext.Users.FirstOrDefault(user => user.Email == userEmail);
            // Create a new instance of UserWedding
            UserWedding TEMP = new UserWedding();
            // Populate the new instance            
            TEMP.UserId = GrabbedUser.UserId;
            TEMP.WeddingId = weddingId;
            // Holy hell we can add it to the table now!
            dbContext.UsersWeddings.Add(TEMP);
            dbContext.SaveChanges();
            return Redirect("/dashboard");
        }
        [HttpGet("processRemoveUserFromWedding/{weddingId}/{userEmail}")]
        public IActionResult ProcessRemoveUserFromWedding(int weddingId, string userEmail)
        {
            // link the tables based on the one wedding
            var RetrievedWedding = dbContext.Weddings
                .Include(join => join.WeddingToJoin)
                .ThenInclude(join => join.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);
            // Grab the UserId
            var GrabbedUser = dbContext.Users.FirstOrDefault(user => user.Email == userEmail);
            // Grab the row in the database that has the link
            var GrabbedRow = dbContext.UsersWeddings.FirstOrDefault(user => user.UserId == GrabbedUser.UserId);
            dbContext.UsersWeddings.Remove(GrabbedRow);
            dbContext.SaveChanges();
            return Redirect("/dashboard");
        }









        [HttpGet("new")]
        public IActionResult New()
        {
            // First ensure that someone is in session
            string VerifyLoggedIn = HttpContext.Session.GetString("UserEmail");
            if(VerifyLoggedIn != null)
            {
                // Grab session and throw in ViewBag to assign the owner property
                @ViewBag.VerifyLoggedIn = VerifyLoggedIn;
                return View();
            }
            // Oops someone isn't in session?
            return View("Index");
        }


        [HttpPost("processNewWedding")]
        public IActionResult ProcessNewWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                //Verify that the date of the wedding is in the future!
                if(newWedding.Date < DateTime.Now)
                {
                    ModelState.AddModelError("Date", "The date of the wedding must be in the future.");
                    return View("New");
                }
                //Store in the database
                dbContext.Add(newWedding);
                //Never forget to save!
                dbContext.SaveChanges();
                return Redirect($"/wedding/{newWedding.WeddingId}");
            }
            return View("New");
        }

        















        [HttpGet("wedding/{WeddingId}")]
        public IActionResult Wedding(int WeddingId)
        {
            //First Make sure there is a user logged in
            string VerifyLoggedIn = HttpContext.Session.GetString("UserEmail");
            if(VerifyLoggedIn != null)
            {
                // Let's grab this specific wedding to make sure we can display the right information
                Wedding CurrentWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == WeddingId);
                // Format the date to not look like shit
                DateTime thisDate = CurrentWedding.Date;
                string ThisDate = thisDate.ToLongDateString();
                ViewBag.ThisDate = ThisDate;
                // Let's be able to use it in our .cshtml
                ViewBag.CurrentWedding = CurrentWedding;

                //Link the wedding to see the guests
                var WeddingWithJoin = dbContext.Weddings
                    .Include(j => j.WeddingToJoin)
                    .ThenInclude(j => j.User)
                    .FirstOrDefault(w => w.WeddingId == WeddingId);
                // Now save the joined wedding in ViewBag
                ViewBag.WeddingWithJoin = WeddingWithJoin;

                return View();
            }
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
