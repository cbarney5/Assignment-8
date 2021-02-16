using System;
using System.Linq;

namespace Assignment5.Models
{
    public class EFBookstoreRepository : iBookstoreRepository
    {
        private BookstoreDbContext _context;

        //Constructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }


        public IQueryable<Book> Books => _context.Books;
    }
}
