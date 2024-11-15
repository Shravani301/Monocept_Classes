using AuthorBookApi.DTOs;
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
            return false;
        }

       
        public BookDto GetBookById(int id)
        {
            var book = _bookRepository.GetById(id);
            BookDto bookDto= _mapper.Map<BookDto>(book);
            return bookDto; 
        }

        public List<BookDto> GetBooks()
        {
            var books= _bookRepository.GetAll().ToList();
            List<BookDto> bookDtos = _mapper.Map<List<BookDto>>(books);
            return bookDtos;
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
            return false;
        }
    }
}
