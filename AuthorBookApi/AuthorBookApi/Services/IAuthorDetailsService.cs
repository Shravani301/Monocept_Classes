using AuthorBookApi.DTOs;
using AuthorBookApi.Models;

namespace AuthorBookApi.Services
{
    public interface IAuthorDetailsService
    {
        public List<AuthorDetailsDto> GetAuthorDetails();
        public AuthorDetailsDto GetAuthorDetailsById(int id);
        public int Add(AuthorDetailsDto authorDetailsDto);
        public bool Update(AuthorDetailsDto authorDetailsDto);
        public bool Delete(int id);
    }
}
