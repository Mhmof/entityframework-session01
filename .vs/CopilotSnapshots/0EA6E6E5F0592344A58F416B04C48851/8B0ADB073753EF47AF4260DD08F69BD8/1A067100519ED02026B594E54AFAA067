using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Data;
using ReadMoreBooks.Models;

namespace ReadMoreBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookstoreContext();
            context.Database.EnsureCreated();
        }
    }
}
