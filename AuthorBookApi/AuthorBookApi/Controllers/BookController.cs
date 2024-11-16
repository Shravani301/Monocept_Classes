using AuthorBookApi.DTOs;
using AuthorBookApi.Models;
using AuthorBookApi.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AuthorBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var bookDtos = _bookService.GetBooks();
            return Ok(bookDtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bookDto = _bookService.GetBookById(id);
            return Ok(bookDto);
        }
        [HttpPost]
        public IActionResult Add(BookDto bookDto)
        {
            var newBook = _bookService.Add(bookDto);
            return Ok(newBook);
        }

        [HttpPut]
        public IActionResult Modify(BookDto bookDto)
        {
            if (_bookService.Update(bookDto))

                return Ok(bookDto);

            return NotFound("No such Book found");
        }

        [HttpGet("author/{id}")]
        public IActionResult GetBooksbyAuthorId(int id)
        {
            var bookDtos = _bookService.GetBooksByAuthorId(id);
            if (bookDtos != null)
                return Ok(bookDtos);
            return NotFound("Books do not exist");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_bookService.Delete(id))
            {
                return Ok("Deleted Successfully");
            }
            return NotFound("No such book found to delete");
        }
    }
}
