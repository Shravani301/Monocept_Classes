using AuthorBookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorDetails> AuthorDetails { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    }
}
