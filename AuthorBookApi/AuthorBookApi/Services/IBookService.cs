using AuthorBookApi.DTOs;
using AuthorBookApi.Models;

namespace AuthorBookApi.Services
{
    public interface IBookService
    {
        public List<BookDto> GetBooks();
        public BookDto GetBookById(int id);
        public int Add(BookDto bookDto);
        public bool Update(BookDto bookDto);
        public bool Delete(int id);
    }
}
