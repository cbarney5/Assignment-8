using System;
using System.Linq;

namespace Assignment5.Models
{
    public interface iBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
