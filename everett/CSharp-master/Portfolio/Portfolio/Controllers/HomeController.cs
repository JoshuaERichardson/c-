using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{

    public class HomeController : Controller
    {
        //Requests
        // localhost: 5000/
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            return View();
        }
        
        // localhost: 5000/hello
         [Route("hello")]
         [HttpGet]
         public string Hello()
         {
             return "Hello From Hello";
         }

                 // You may also serve the same view twice from additional actions
        [HttpGet("elsewhere")]
        public ViewResult Elsewhere()
        {
            return View("Index");
        }

        //JSON
        // [HttpGet]
        // [Route("json")]
        // public JsonResult Example()
        // {
        //     // The Json method converts the object passed to it into JSON
        //     return Json(SomeObject);
        // }

        // Other JSON
        [HttpGet]
        [Route("displayanon")]
        public JsonResult DisplayAnon()
        {
            var AnonObject = new {
                FirstName = "Raz",
            LastName = "Aquato",
                Age = 10
            };
            
            return Json(AnonObject);
        }
        
        //Interface - IactionResult:  changes based on actions

        [HttpGet("random")]
        public ViewResult Index2()
        {
            return View();
        }
        [HttpGet("{favoriteResponse}")]
        public IActionResult ItDepends(string favoriteResponse)
        {
            if(favoriteResponse == "Redirect")
            {
                return RedirectToAction("Index");
            }
            else if(favoriteResponse == "Json")
            {
                return Json(new {FavoriteResponse = favoriteResponse});
            }
            return View();
        }

        //VIEWBAG EXAMPLE

            [HttpGet]
            [Route("viewbag")]
            public IActionResult Viewbag()
            {
                // Here we assign the value "Hello World!" to the property .Example
                // Property names are arbitrary and can be whatever you like
                ViewBag.Example = "Hello World!";
                return View();
            }


        ///END
    }
}