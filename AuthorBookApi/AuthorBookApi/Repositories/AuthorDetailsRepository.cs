using AuthorBookApi.Data;
using AuthorBookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Repositories
{
    public class AuthorDetailsRepository:IAuthorDetailsRepository
    {
        private readonly LibraryContext _context;
        public AuthorDetailsRepository(LibraryContext context)
        {
            _context = context;
        }
        public AuthorDetails GetAuthorDetailsById(int id)
        {
            return _context.AuthorDetails.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public List<AuthorDetails> GetAuthorDetails()
        {
            return _context.AuthorDetails.ToList();
        }
        public int Add(AuthorDetails authorDetails)
        {
            _context.AuthorDetails.Add(authorDetails);
            _context.SaveChanges();
            return authorDetails.Id;
        }
        public int Update(AuthorDetails authorDetails)
        {
            _context.AuthorDetails.Entry(authorDetails).State = EntityState.Modified;
            _context.AuthorDetails.Update(authorDetails);
            _context.SaveChanges();
            return authorDetails.Id;
        }
        public void Delete(AuthorDetails authorDetails)
        {
            _context.AuthorDetails.Remove(authorDetails);
            _context.SaveChanges();
        }
    }
}
