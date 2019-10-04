using Microsoft.AspNetCore.Mvc;

    namespace time_display.Controllers     //be sure to use your own project's namespace!
    {
        public class MainController : Controller
        {
            //for each route this controller is to handle:
            [HttpGet("")]       //type of request
            public ViewResult Index()
            {
           
                return View();
            }
        }
    }
