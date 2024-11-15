using AuthorBookApi.DTOs;
using AuthorBookApi.Models;
using AuthorBookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthorBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var authorDtos= _authorService.GetAuthors();
            return Ok(authorDtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var authorDto =_authorService.GetAuthorById(id);
            return Ok(authorDto);
        }

        [HttpPost]
        public IActionResult Add(AuthorDto authorDto)
        {
            var newAuthor=_authorService.Add(authorDto);
            return Ok(newAuthor);
        }

        [HttpPut]
        public IActionResult Modify(AuthorDto authorDto)
        {
            if (_authorService.Update(authorDto))

                return Ok(authorDto);

            return NotFound("No such Author found");
        }

        [HttpGet("by-name/{name}")]
        public IActionResult GetByName(string name)
        {
            var authorDto = _authorService.GetAuthorByName(name);
            if (authorDto == null)
                return NotFound("No such author found");
            return Ok(authorDto);
        }

        [HttpGet("{id}/details")]
        public IActionResult GetAuthorDetailsById(int id)
        {
            var authorDetails = _authorService.GetAuthorDetails(id);
            if (authorDetails == null)
                return NotFound("No such Author Found");
            return Ok(authorDetails);
        }

        [HttpGet("{id}/books")]
        public IActionResult GetBooksbyAuthorId(int id)
        {
            var bookDtos = _authorService.GetBooksByAuthorId(id);
            if (bookDtos != null)
                return Ok(bookDtos);
            return NotFound("Books do not exist");
        }

        [HttpGet("author/{id}")]
        public IActionResult GetAuthorByBookId(int id)
        {
            var authorDto = _authorService.GetAuthorByBookId(id);
            if (authorDto == null)
                return NotFound("Author does not exist");
            return Ok(authorDto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_authorService.Delete(id))
            {
                return Ok("Deleted Successfully!");
            }
            return NotFound("No such Author found to delete");
        }
    }
}
