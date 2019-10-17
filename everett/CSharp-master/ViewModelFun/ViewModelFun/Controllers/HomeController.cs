using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string torender = "This is a render";

            return View("Index", torender);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6,9,10,22
            };
            return View(numbers);
        }

        [HttpGet("user")]
        public IActionResult User(){
            MyModel Josh = new MyModel(){
                FirstName = "Josh",
                LastName = "Everett"
            };
            return View(Josh);
        }

        [HttpGet("users")]
        public IActionResult Users(){
            MyModel Britt = new MyModel(){
                FirstName = "Brittany",
                LastName = "Everett"
            };
            MyModel Addison = new MyModel(){
                FirstName = "Addison",
                LastName = "Everett"
            };
            MyModel Kinsley = new MyModel(){
                FirstName = "Kinsley",
                LastName = "Everett"
            };
            MyModel Josh = new MyModel(){
                FirstName = "Josh",
                LastName = "Everett"
            };
            
            List<MyModel> allUsers = new List<MyModel>()
            {
                Josh, Britt, Kinsley, Addison
            };
            return View(allUsers);
        }

    }
}