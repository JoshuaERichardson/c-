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
            if(newUser.Name !=  null && newUser.Alias != null)
            {
                //Start with if everything was entered correctly
                if(ModelState.IsValid)
                {
                    // check to make sure name is all letters or a space
                    foreach(char c in newUser.Name)
                    {
                        // need to fix the whitespace
                        if(!Char.IsLetter(c))
                        {
                            if(!Char.IsWhiteSpace(c))
                            {
                            ModelState.AddModelError("Name", "Name must be only letters or spaces");
                            return View("Index");
                            }
                        }
                    }
                    foreach(char c in newUser.Alias)
                    {
                        
                        // need to fix the logins
                        if(!Char.IsLetter(c))
                        {
                            if(!Char.IsDigit(c))
                            {
                              ModelState.AddModelError("Alias", "Alias must be only letters or numbers");
                              return View("Index");
                            }
                        }
                    }
                    
                    // If the email is already used throw an error
                    
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
                            if (user.Alias == newUser.Alias)
                            {
                                ModelState.AddModelError("Alias", "Alias already in use!");
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
                        HttpContext.Session.SetString("UserEmail", newUser.Alias);
                        return RedirectToAction("New");
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
                        HttpContext.Session.SetString("UserEmail", user.Alias);
                        return RedirectToAction("New");
                    }
                }
            return View("Index");
        }






        [HttpGet("users/{UserAlias}")]
        public IActionResult UserView(string UserAlias)
        {
            //grab the one user passed
            User GrabbedUser = dbContext.Users
                .FirstOrDefault(u => u.Alias == UserAlias);
            @ViewBag.GrabbedUser = GrabbedUser;
            return View();
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
            return Redirect("/bright_ideas");
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
            var GrabbedUser = dbContext.Users.FirstOrDefault(user => user.Alias == userEmail);
            // Create a new instance of UserWedding
            UserWedding TEMP = new UserWedding();
            // Populate the new instance            
            TEMP.UserId = GrabbedUser.UserId;
            TEMP.WeddingId = weddingId;
            // Holy hell we can add it to the table now!
            dbContext.UsersWeddings.Add(TEMP);
            dbContext.SaveChanges();
            return Redirect("/bright_ideas");
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
            return Redirect("/bright_ideas");
        }









        [HttpGet("bright_ideas")]
        public IActionResult New()
        {
            // First ensure that someone is in session
            string VerifyLoggedIn = HttpContext.Session.GetString("UserEmail");
            if(VerifyLoggedIn != null)
            {
                // Grab session and throw in ViewBag to assign the owner property
                @ViewBag.VerifyLoggedIn = VerifyLoggedIn;
                

                // Grab all Ideas to loop through
                List<Wedding> AllIdeas = dbContext.Weddings
                    .Include(i => i.WeddingToJoin)
                    .ThenInclude(i => i.User)
                    .ToList();
                @ViewBag.AllIdeas = AllIdeas;

                List<UserWedding> AllAssociations = dbContext.UsersWeddings.ToList();
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
                //Store in the database
                newWedding.Idea = $"{newWedding.Idea}";
                dbContext.Add(newWedding);
                //Never forget to save!
                dbContext.SaveChanges();
                return Redirect("/bright_ideas");
            }
            return View("New");
        }

        















        [HttpGet("bright_ideas/{WeddingId}")]
        public IActionResult Wedding(int WeddingId)
        {
            //First Make sure there is a user logged in
            string VerifyLoggedIn = HttpContext.Session.GetString("UserEmail");
            if(VerifyLoggedIn != null)
            {
                // Let's grab this specific wedding to make sure we can display the right information
                Wedding CurrentIdea = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == WeddingId);

                // Let's be able to use it in our .cshtml
                ViewBag.CurrentIdea = CurrentIdea;

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
