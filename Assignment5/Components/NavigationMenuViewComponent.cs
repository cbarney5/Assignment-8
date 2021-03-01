using System;
using System.Linq;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {//Select Categories
        private iBookstoreRepository repository;

        public NavigationMenuViewComponent(iBookstoreRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
