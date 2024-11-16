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
            _authorService.Update(authorDto);
            return Ok(authorDto);
        }

        [HttpGet("author/{name}")]
        public IActionResult GetByName(string name)
        {
            var authorDto = _authorService.GetAuthorByName(name);
            return Ok(authorDto);
        }

        [HttpGet("book/{id}")]
        public IActionResult GetAuthorByBookId(int id)
        {
            var authorDto = _authorService.GetAuthorByBookId(id);
            return Ok(authorDto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Deleted Successfully!");
        }
    }
}
