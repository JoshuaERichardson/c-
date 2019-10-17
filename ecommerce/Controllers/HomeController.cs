using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;

namespace ecommerce.Controllers
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
            return View();
        }
































        [HttpGet("orders")]
        public IActionResult Orders()
        {
            return View();
        }
        [HttpPost("processNewOrder")]
        public IActionResult ProcessNewOrder()
        {
            return Redirect("/orders");
        }
































        [HttpGet("customers")]
        public IActionResult Customers()
        {
            return View();
        }
        [HttpPost("processNewCustomer")]
        public IActionResult ProcessNewCustomer()
        {
            return Redirect("/customers");
        }
        [HttpGet("processRemoveCustomer/{custId}")]
        public IActionResult ProcessRemoveCustomer(int custId)
        {
            return Redirect("/customers");
        }






























        [HttpGet("products")]
        public IActionResult Products()
        {
            return View();
        }
        [HttpPost("processNewProduct")]
        public IActionResult ProcessNewProduct(Product newProduct)
        {
            return Redirect("/products");
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
