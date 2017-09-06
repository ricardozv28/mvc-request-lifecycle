using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCPresentation.Models;

namespace MVCPresentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [IsMobile]
        [ActionName("Index")]
        public IActionResult MobileIndex()
        {
            return Content("Mobile View");
        }
        [ResultLog]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        [Route("/controller/hello")]
        public IActionResult HelloWorld()
        {
            return Content("hello world from C#");
        }
        [LogAction]
        public IActionResult Splash()
        {
            return Content("This is the splash page");
        }
        [LocalAuthorize]
        public IActionResult Edit()
        {
            return Content("The Edit Method");
        }
        [HttpPost]
        public IActionResult Edit(int index, string name)
        {
            return Content("The Edit Method with parameters.");
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById([ModelBinder(Name = "id")] Movie movie)
        {
            if (movie == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(movie);
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(Movie author)
        {
            return Ok(author);
        }

    }
}
