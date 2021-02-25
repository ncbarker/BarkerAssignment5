using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookStoreDbContext _context;
        
        //Constructor
        public EFBookStoreRepository (BookStoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Project> Projects => _context.Projects;

    }
}
