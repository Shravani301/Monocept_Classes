using AuthorBookApi.DTOs;
using AuthorBookApi.Models;
using AuthorBookApi.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IRepository<Author> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public int Add(AuthorDto authorDto)
        {
            var author=_mapper.Map<Author>(authorDto);
             _authorRepository.Add(author);
            return author.Id;
        }

        public bool Delete(int id)
        {
            var existingAuthor = _authorRepository.GetById(id);
            if (existingAuthor != null)
            {
                _authorRepository.Delete(existingAuthor);
                return true;
            }
            return false;
        }

        public AuthorDto GetAuthorById(int id)
        {
            var author= _authorRepository.GetById(id);
            AuthorDto authorDto=_mapper.Map< AuthorDto>(author);    
            return authorDto;
        }
        
        public List<AuthorDto> GetAuthors()
        {
            var authors=_authorRepository.GetAll().Include(a=>a.AuthorDetails).Include(a=>a.Books).ToList();
            List<AuthorDto> authorDtos = _mapper.Map<List<AuthorDto>>(authors);
            return authorDtos;
        }

        public bool Update(AuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            var existingAuthor = _authorRepository.GetAll().AsNoTracking().FirstOrDefault(a=>a.Id == author.Id);
            if (existingAuthor != null)
            {
                _authorRepository.Update(author);
                return true;
            }
            return false;
        }

        public AuthorDto GetAuthorByName(string name)
        {
            var author = _authorRepository.GetAll().FirstOrDefault(a => a.Name == name);
            AuthorDto authorDto = _mapper.Map<AuthorDto>(author);
            return authorDto;
        }

        public AuthorDetailsDto GetAuthorDetails(int id)
        {
            var authorDetails = _authorRepository.GetAll().
                Include(a => a.AuthorDetails).FirstOrDefault(a => a.Id == id)?.AuthorDetails;
            var authorDetailsDto=_mapper.Map<AuthorDetailsDto>(authorDetails);
            return authorDetailsDto;
        }
        public List<BookDto> GetBooksByAuthorId(int authorId)
        {
            var books = _authorRepository.GetAll().Include(b => b.Books).FirstOrDefault(a => a.Id == authorId)?.Books;
            List<BookDto> bookDtos=_mapper.Map<List<BookDto>>(books);   
            return bookDtos;
        }
        public AuthorDto GetAuthorByBookId(int bookId)
        {
            var author = _authorRepository.GetAll().Include(b => b.Books).FirstOrDefault(a => a.Id == bookId);
            AuthorDto authorDto = _mapper.Map<AuthorDto>(author);
            return authorDto;

        }
    }
}
