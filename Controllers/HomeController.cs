using BarkerAssignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BarkerAssignment5.Models.ViewModels;

namespace BarkerAssignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Private variable for the book store repository
        private  IBookStoreRepository _repository;

        //Variable to only show 5 items per page
        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, IBookStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        //Result for the Index page
        public IActionResult Index(string category, int pageNum = 1)
        {
            //Only show 5 items per page
            return View(new BookListViewModel
            {
                Projects = _repository.Projects
                    .Where(p => category == null || p.BookCat == category)
                    .OrderBy(p => p.BookId)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo =  new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Projects.Count() :
                        _repository.Projects.Where(x => x.BookCat == category).Count()

                },
                //Allow for filtering according to category
                CurrentCategory = category
                
            });
                
                
                
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
