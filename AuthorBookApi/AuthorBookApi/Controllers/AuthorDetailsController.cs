using AuthorBookApi.DTOs;
using AuthorBookApi.Models;
using AuthorBookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthorBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorDetailsController : ControllerBase
    {
        private readonly IAuthorDetailsService _authorDetailsService;
        public AuthorDetailsController(IAuthorDetailsService authorDetailsService)
        {
            _authorDetailsService = authorDetailsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var authorDetailsDtos =_authorDetailsService.GetAuthorDetails();
            return Ok(authorDetailsDtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var authorDetailsDto = _authorDetailsService.GetAuthorDetailsById(id);
            return Ok(authorDetailsDto);
        }
        [HttpPost]
        public IActionResult Add(AuthorDetailsDto authorDetailsDto)
        {
            var newAuthorDetails=_authorDetailsService.Add(authorDetailsDto);
            return Ok(newAuthorDetails);
        }

        [HttpPut]
        public IActionResult Modify(AuthorDetailsDto authorDetailsDto)
        {
            _authorDetailsService.Update(authorDetailsDto);
                return Ok(authorDetailsDto);
        }
        [HttpGet("author/{id}")]
        public IActionResult GetAuthorDetailsByAuthorId(int id)
        {
            var authorDetails = _authorDetailsService.GetAuthorDetails(id);
            return Ok(authorDetails);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _authorDetailsService.Delete(id);
                return Ok("Author Details Deleted Successfully");
        }
    }
}
