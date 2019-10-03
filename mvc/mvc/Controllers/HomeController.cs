using Microsoft.AspNetCore.Mvc;
namespace mvc
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public string  Index()
        {
            return "Hello From Controller";
        }
        // localhoost:5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi again!";
        }
        // localhost:5000/users/???
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            return $"Hello, {username} from {location}";
        }
    }
}