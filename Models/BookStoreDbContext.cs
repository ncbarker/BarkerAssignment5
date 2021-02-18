using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext (DbContextOptions<BookStoreDbContext> options) : base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
