using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Building a view model for each page in particular
//Doing thid helps make the program and datavase flexble
namespace BarkerAssignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }


    }
}
