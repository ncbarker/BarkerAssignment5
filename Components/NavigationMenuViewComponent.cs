using BarkerAssignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Components
{
    //Inherit from the ViewComponent
    public class NavigationMenuViewComponent: ViewComponent
    {
        //Bring the repository into the class

        private IBookStoreRepository repository;

        //go through the constructor
        public NavigationMenuViewComponent (IBookStoreRepository r)
        {
            repository = r;
        }
        
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.BookCat)
                .Distinct()
                .OrderBy(x => x));

        }

    }
}
