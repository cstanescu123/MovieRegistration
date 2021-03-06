using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movie()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel movie)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(movie);
        }
        public IActionResult Result(MovieViewModel movieViewModel)
        {
            var resultViewModel = new ResultViewModel();
            resultViewModel.Title = movieViewModel.Title;
            return View(resultViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
