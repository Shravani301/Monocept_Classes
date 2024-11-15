using AuthorBookApi.Data;
using AuthorBookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _context;
        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }
        public int Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return author.Id;
        }

        public void Delete(Author author)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public int Update(Author author)
        {
            _context.Authors.Entry(author).State = EntityState.Modified;
            _context.Authors.Update(author);
            _context.SaveChanges();
            return author.Id;
        }
    }
}
