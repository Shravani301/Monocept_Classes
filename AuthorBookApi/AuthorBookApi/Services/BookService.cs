using AuthorBookApi.DTOs;
using AuthorBookApi.Exceptions;
using AuthorBookApi.Models;
using AuthorBookApi.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Services
{
    public class BookService:IBookService
    {

        private readonly IRepository<Book> _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IRepository<Book> bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public int Add(BookDto bookDto)
        {
            var book= _mapper.Map<Book>(bookDto);
             _bookRepository.Add(book);
            return book.Id;
        }
        public bool Delete(int id)
        {
            var existingBook = _bookRepository.GetById(id);
            if (existingBook != null)
            {
                _bookRepository.Delete(existingBook);
                return true;
            }
            throw new BookNotFoundException("Book not found to delete");
        }

       
        public BookDto GetBookById(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book != null)
            {
                BookDto bookDto = _mapper.Map<BookDto>(book);
                return bookDto;
            }
            throw new BookNotFoundException("Book not found");
        }

        public List<BookDto> GetBooks()
        {
            var books= _bookRepository.GetAll().ToList();
            if (books != null)
            {
                List<BookDto> bookDtos = _mapper.Map<List<BookDto>>(books);
                return bookDtos;
            }
            throw new BooksDoesNotExistException("Books does not exist");
        }
        public List<BookDto> GetBooksByAuthorId(int authorId)
        {
            var books = _bookRepository.GetAll().Include(a => a.Author).FirstOrDefault(a => a.Id == authorId);
            if (books != null)
            {
                List<BookDto> bookDtos = _mapper.Map<List<BookDto>>(books);
                return bookDtos;
            }
            throw new BooksDoesNotExistException("Books does not exist");
        }

        public bool Update(BookDto bookDto)
        {
            var book=_mapper.Map<Book>(bookDto);

            var existingBook = _bookRepository.GetAll().AsNoTracking().FirstOrDefault(a => a.Id == book.Id);

            if (existingBook != null)
            {
                _bookRepository.Update(book);
                return true;
            }
            throw new BookNotFoundException("Book not found");
        }
    }
}
