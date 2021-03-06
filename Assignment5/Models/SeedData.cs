using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment5.Models
{
    public class SeedData
    {
       public static void EnsurePopulated (IApplicationBuilder application)
        {   //Migrates
            BookstoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    //Seeds Data
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageNum = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-07432707559",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageNum = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageNum = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageNum = 864
                    },
                     new Book
                     {
                         Title = "Unbroken",
                         AuthorFirstName = "Laura",
                         AuthorLastName = "Hillenbrand",
                         Publisher = "Random House",
                         ISBN = "978-0812974492",
                         Classification = "Non-Fiction",
                         Category = "Historical",
                         Price = 13.33,
                         PageNum = 528
                     },
                      new Book
                      {
                          Title = "The Great Train Robbery",
                          AuthorFirstName = "Michael",
                          AuthorLastName = "Chrichton",
                          Publisher = "Vintage",
                          ISBN = "978-0804171281",
                          Classification = "Fiction",
                          Category = "Historical Fiction",
                          Price = 15.95,
                          PageNum = 288
                      },
                      new Book
                      {
                          Title = "Deep Work",
                          AuthorFirstName = "Cal",
                          AuthorLastName = "Newport",
                          Publisher = "Grand Central Publishing",
                          ISBN = "978-1455586691",
                          Classification = "Non-Fiction",
                          Category = "Self-Help",
                          Price = 14.99,
                          PageNum = 304
                      },
                       new Book
                       {
                           Title = "It's Your Ship",
                           AuthorFirstName = "Michael",
                           AuthorLastName = "Abrashoff",
                           Publisher = "Grand Central Publishing",
                           ISBN = "978-1455523023",
                           Classification = "Non-Fiction",
                           Category = "Self-Help",
                           Price = 21.66,
                           PageNum = 240
                       },
                        new Book
                        {
                            Title = "The Virgin Way",
                            AuthorFirstName = "Richard",
                            AuthorLastName = "Branson",
                            Publisher = "Portfolio",
                            ISBN = "978-1591847984",
                            Classification = "Non-Fiction",
                            Category = "Business",
                            Price = 29.16,
                            PageNum = 400
                        },
                        new Book
                        {
                            Title = "Sycamore Row",
                            AuthorFirstName = "John",
                            AuthorLastName = "Grisham",
                            Publisher = "Bantam",
                            ISBN = "978-0553393613",
                            Classification = "Fiction",
                            Category = "Thrillers",
                            Price = 15.03,
                            PageNum = 642
                        },
                        new Book
                        {
                            Title = "Hunger Games",
                            AuthorFirstName = "Suzanne",
                            AuthorLastName = "Collins",
                            Publisher = "Scholastic Corporation",
                            ISBN = "978-055339238",
                            Classification = "Fiction",
                            Category = "Fantasy",
                            Price = 8.53,
                            PageNum = 250
                        },
                        new Book
                        {
                            Title = "How to Win Friends and Influence People",
                            AuthorFirstName = "Dale",
                            AuthorLastName = "Carnegie",
                            Publisher = "Simon & Schuster",
                            ISBN = "978-0553393746",
                            Classification = "Non-Fiction",
                            Category = "Business",
                            Price = 8.49,
                            PageNum = 175
                        },
                        new Book
                        {
                            Title = "Harry Potter",
                            AuthorFirstName = "J.K.",
                            AuthorLastName = "Rowling",
                            Publisher = "Bloomsbury Publishing",
                            ISBN = "978-0553393876",
                            Classification = "Fiction",
                            Category = "Fantasy",
                            Price = 12.03,
                            PageNum = 683
                        }

                    ) ;
                    context.SaveChanges();
            }
        }
    }
}
