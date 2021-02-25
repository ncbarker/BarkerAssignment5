using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        
        //Calculate how many pages will be needed
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
