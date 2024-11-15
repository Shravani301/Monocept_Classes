using AuthorBookApi.DTOs;
using AuthorBookApi.Models;

namespace AuthorBookApi.Services
{
    public interface IAuthorService
    {
        public List<AuthorDto> GetAuthors();
        public AuthorDto GetAuthorById(int id);
        public int Add(AuthorDto authorDto);
        public bool Update(AuthorDto authorDto);
        public bool Delete(int id);
        public AuthorDto GetAuthorByName(string name);
        public AuthorDetailsDto GetAuthorDetails(int id);
        public List<BookDto> GetBooksByAuthorId(int authorId);
        public AuthorDto GetAuthorByBookId(int bookId);
    }
}
