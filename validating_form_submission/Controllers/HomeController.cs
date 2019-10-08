using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validating_form_submission.Models;

namespace validating_form_submission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/User")]
        public IActionResult Index(User response)
        {
            if(ModelState.IsValid)
            {
                return Redirect("success");
            }
            else
            {
                return Redirect("/");
            }
        }

    }
}
