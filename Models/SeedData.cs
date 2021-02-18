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

            if(context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        
                        BookTitle = "Les Miserables",
                        AuthFName = "Victor",
                        AuthLName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        BookCat = "Fiction, Classic",
                        BookPrice = 9.95
                    },
                    new Project
                    {
                        
                        BookTitle = "Team of Rivals",
                        AuthFName = "Doris Kearns",
                        AuthLName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        BookCat = "Non-Fiction, Biography",
                        BookPrice = 14.58
                    },

                    new Project
                    {
                        
                        BookTitle = "The Snowball",
                        AuthFName = "Alice",
                        AuthLName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        BookCat = "Non-Fiction, Biography",
                        BookPrice = 21.54
                    },
                    new Project
                    {
                        
                        BookTitle = "American Ulysses",
                        AuthFName = "Ronald C.",
                        AuthLName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        BookCat = "Non-Fiction, Biography",
                        BookPrice = 11.61
                    },
                    new Project
                    {
                        
                        BookTitle = "Unbroken",
                        AuthFName = "Laura",
                        AuthLName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        BookCat = "NonFiction, Biography",
                        BookPrice = 13.33
                    },
                    new Project
                    {
                        
                        BookTitle = "The Great Train Robbery",
                        AuthFName = "Michael",
                        AuthLName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        BookCat = "Fictional, Historical Fiction",
                        BookPrice = 15.95
                    },
                    new Project
                    {
                        
                        BookTitle = "Deep Work",
                        AuthFName = "Cal",
                        AuthLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        BookCat = "Non-Fiction, Self-Help",
                        BookPrice = 14.99
                    },
                    new Project
                    {
                        
                        BookTitle = "It's Your Ship",
                        AuthFName = "Michael",
                        AuthLName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        BookCat = "Non-Fiction, Self-Help",
                        BookPrice = 21.66
                    },
                    new Project
                    {
                        
                        BookTitle = "The Virgin Way",
                        AuthFName = "Richard",
                        AuthLName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        BookCat = "Non-Fiction, Business",
                        BookPrice = 29.16
                    },
                    new Project
                    {
                        
                        BookTitle = "Sycamore Row",
                        AuthFName = "John",
                        AuthLName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        BookCat = "Fiction, Thrillers",
                        BookPrice = 15.03
                    }

                );

                context.SaveChanges();
                
            }
        }
    }
}
