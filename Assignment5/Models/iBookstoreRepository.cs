using System;
using System.Linq;

namespace Assignment5.Models
{   //Places books into a repository that is queryable
    public interface iBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
