﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment5.Models;
using Assignment5.Models.ViewModels;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {   //Sets repository and logger vars
        private readonly ILogger<HomeController> _logger;

        private iBookstoreRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, iBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
     
        //Link statement to dynamically update page size and number
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new ProjectListViewModel
            {
                Books = _repository.Books
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.BookId)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Books.Count():
                    _repository.Books.Where(x => x.Category == category).Count()
                },
                Category = category
                    
        });


                
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //Hilton said don't worry about it
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
