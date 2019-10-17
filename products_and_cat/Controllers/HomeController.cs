using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using products_and_cat.Models;

namespace products_and_cat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        // Render Existing products and add product
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
                return RedirectToAction("Products");
            }
            return View("Products");
        }
        // View all Categories and add one
        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.AllCategories = AllCategories;
            return View();
        }
        [HttpPost]
        public IActionResult ProcessNewCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            return View("Categories");
        }

        // view one product and add categories
        [HttpGet("Products/{hlinkProductId}")]
        public IActionResult AddCategory(int hlinkProductId)
        {
            Product oneProduct = dbContext.Products.FirstOrDefault(product => product.ProductId == hlinkProductId);
            ViewBag.oneProduct = oneProduct;
            //  WHAT'S MY GOAL?
            //  I WANT TO GRAB ONE PRODUCT AND SHOW ITS CATEGORIES!
            
            var productWithAssociationAndCategory = dbContext.Products
                .Include(product => product.ProductToCat)
                .ThenInclude(cat => cat.Category)
                .FirstOrDefault(product => product.ProductId == hlinkProductId);
            ViewBag.productWithAssociationAndCategory = productWithAssociationAndCategory;

            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.AllCategories = AllCategories;
            // Check to see if each category is in productWithAssociationAndCategory already!
            // List<Category> NonAssociatedCategories = null;
            // List<Category> AssociatedCategories = null;
           
           //loop through all categories

            
            var products = Product
                .Where(x=> x.ProductToCat.Any(c=> Name.Contains(c.Name)));
            
            foreach(var i in AllCategories)
            {
                //loop through 
            }


            // foreach(var i in AllCategories)
            // {

            //     // find all the categories currently in it and then 
            //     foreach(var j in productWithAssociationAndCategory.ProductToCat)
            //     {
            //         if(i.CategoryId == j.CategoryId)
            //         {
            //             AssociatedCategories = dbContext.Categories.ToList();
            //         }
            //     }
            // }
            // foreach(var i in AllCategories)
            // {
            //     foreach(var j in productWithAssociationAndCategory.ProductToCat)
            //     {
            //         if(i.CategoryId != j.CategoryId)
            //         {
            //             NonAssociatedCategories = dbContext.Categories.ToList();
            //         }
            //     }
            // }
            // ViewBag.AssociatedCategories = AssociatedCategories;
            // ViewBag.NonAssociatedCategories = NonAssociatedCategories;
            return View(productWithAssociationAndCategory);
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
