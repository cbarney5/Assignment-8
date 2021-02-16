using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private iBookstoreRepository _repository;

        public HomeController(ILogger<HomeController> logger, iBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
     
        [HttpPost]
        public IActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                return View(_repository.Books);
            }
            return View();
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
