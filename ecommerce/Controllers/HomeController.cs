using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;
using Microsoft.EntityFrameworkCore;

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
            List<Product> Joining = dbContext.Products
                .Include(join => join.ProductOrders)
                .ThenInclude(join => join.Customer)
                .ToList();

            List<Product> FiveProducts = dbContext.Products
                .OrderByDescending(u => u.CreatedAt)
                .Take(5)
                .ToList();
            ViewBag.FiveProducts = FiveProducts;

            List<Order> ThreeOrders = dbContext.Orders
                .OrderByDescending(u => u.CreatedAt)
                .ToList();
            ViewBag.ThreeOrders = ThreeOrders;

            return View();
        }
































        [HttpGet("orders")]
        public IActionResult Orders()
        {
            List<Order> AllOrders = dbContext.Orders.ToList();
            ViewBag.AllOrders = AllOrders;
            
            List<Customer> AllCustomers = dbContext.Customers.ToList();
            ViewBag.AllCustomers = AllCustomers;

            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.AllProducts = AllProducts;
                
            return View();
        }
        [HttpPost("processNewOrder")]
        public IActionResult ProcessNewOrder(Order newOrder)
        {
            if(ModelState.IsValid)
            {
            dbContext.Add(newOrder);
            // Grab the specific item to decrease the Quantity
            Product GrabbedProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == newOrder.ProductId);
            GrabbedProduct.Quantity = GrabbedProduct.Quantity-newOrder.QuantityOrdered;
            dbContext.SaveChanges();
            return Redirect("/orders");
            }
            return View();
        }
































        [HttpGet("customers")]
        public IActionResult Customers()
        {
            List<Customer> AllCustomers = dbContext.Customers.ToList();
            ViewBag.AllCustomers = AllCustomers;
            return View();
        }
        [HttpPost("processNewCustomer")]
        public IActionResult ProcessNewCustomer(Customer newCustomer)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newCustomer);
                dbContext.SaveChanges();
                return Redirect("/customers");
            }
            return View("Customers");
        
        }
        [HttpGet("processRemoveCustomer/{custId}")]
        public IActionResult ProcessRemoveCustomer(int custId)
        {
            // grab the one user
            Customer GrabbedCustomer = dbContext.Customers.FirstOrDefault(id => id.CustomerId == custId);
            dbContext.Customers.Remove(GrabbedCustomer);
            dbContext.SaveChanges();
            return Redirect("/customers");
        }




        // Watch Andrew Ng speak aobut the progress ofAI and what's aroundthe cornerfor AI at amazon re: Mars 2019

























        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.AllProducts = AllProducts;

            return View();
        }
        [HttpPost("processNewProduct")]
        public IActionResult ProcessNewProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newProduct);
                dbContext.SaveChanges();
                return Redirect("/products");
            }
            return View("Products");
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
