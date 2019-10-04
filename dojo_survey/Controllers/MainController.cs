using Microsoft.AspNetCore.Mvc;

    namespace dojo_survey.Controllers     //be sure to use your own project's namespace!
    {
        public class MainController : Controller
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public ViewResult Index()
            {
                return View();
            }

            [HttpPost("survey")]        
            public IActionResult Submission(Survey yourSurvey)
            {

            }
        }
    }