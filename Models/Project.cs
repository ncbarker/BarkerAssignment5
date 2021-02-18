using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public class Project
    {
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthFName { get; set; }
        public string AuthLName { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string BookCat { get; set; }
        public double BookPrice { get; set; }

        

    }
}
