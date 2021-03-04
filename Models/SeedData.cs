using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookStoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        
                        BookTitle = "Les Miserables",
                        AuthFName = "Victor",
                        AuthLName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        BookCat = "Fiction",
                        BookClass = "Classic",
                        Pages = 1488,
                        BookPrice = 9.95
                    },
                    new Project
                    {
                        
                        BookTitle = "Team of Rivals",
                        AuthFName = "Doris Kearns",
                        AuthLName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        BookCat = "Non-Fiction",
                        BookClass = "Biography",
                        Pages = 944,
                        BookPrice = 14.58
                    },

                    new Project
                    {
                        
                        BookTitle = "The Snowball",
                        AuthFName = "Alice",
                        AuthLName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        BookCat = "Non-Fiction",
                        BookClass = "Biography",
                        Pages = 832,
                        BookPrice = 21.54
                    },
                    new Project
                    {
                        
                        BookTitle = "American Ulysses",
                        AuthFName = "Ronald C.",
                        AuthLName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        BookCat = "Non-Fiction",
                        BookClass = "Biography",
                        Pages = 864,
                        BookPrice = 11.61
                    },
                    new Project
                    {
                        
                        BookTitle = "Unbroken",
                        AuthFName = "Laura",
                        AuthLName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        BookCat = "NonFiction",
                        BookClass = "Biography",
                        Pages = 528,
                        BookPrice = 13.33
                    },
                    new Project
                    {
                        
                        BookTitle = "The Great Train Robbery",
                        AuthFName = "Michael",
                        AuthLName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        BookCat = "Fictional",
                        BookClass = "Historical Fiction",
                        Pages = 288,
                        BookPrice = 15.95
                    },
                    new Project
                    {
                        
                        BookTitle = "Deep Work",
                        AuthFName = "Cal",
                        AuthLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        BookCat = "Non-Fiction",
                        BookClass = "Self-Help",
                        Pages = 304,
                        BookPrice = 14.99
                    },
                    new Project
                    {
                        
                        BookTitle = "It's Your Ship",
                        AuthFName = "Michael",
                        AuthLName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        BookCat = "Non-Fiction",
                        BookClass = "Self-Help",
                        Pages = 240,
                        BookPrice = 21.66
                    },
                    new Project
                    {
                        
                        BookTitle = "The Virgin Way",
                        AuthFName = "Richard",
                        AuthLName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        BookCat = "Non-Fiction",
                        BookClass = "Business",
                        Pages = 400,
                        BookPrice = 29.16
                    },
                    new Project
                    {
                        
                        BookTitle = "Sycamore Row",
                        AuthFName = "John",
                        AuthLName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        BookCat = "Fiction",
                        BookClass = "Thriller",
                        Pages = 642,
                        BookPrice = 15.03
                    },
                    new Project
                    {
                        BookTitle = "The Art of Gathering",
                        AuthFName = "Priya",
                        AuthLName = "Parker",
                        Publisher = "Riverhead Books",
                        ISBN = "978-1594634925",
                        BookCat = "Non-Fiction",
                        BookClass = "Business",
                        Pages = 304,
                        BookPrice = 18.95
                    },
                    new Project
                    {
                        BookTitle = "Think Again",
                        AuthFName = "Adam",
                        AuthLName = "Grant",
                        Publisher = "Penguin Random House",
                        ISBN = "978-1984878106",
                        BookCat = "Non-Fiction",
                        BookClass = "Business",
                        Pages = 307,
                        BookPrice = 18.99
                    },
                    new Project
                    {
                        BookTitle = "Range",
                        AuthFName = "David",
                        AuthLName = "Epstein",
                        Publisher = "Riverhead Books",
                        ISBN = "978-0735214484",
                        BookCat = "Non-Fiction",
                        BookClass = "Self-Help",
                        Pages = 339,
                        BookPrice = 14.95
                    }


                );

                context.SaveChanges();
                
            }
        }
    }
}
