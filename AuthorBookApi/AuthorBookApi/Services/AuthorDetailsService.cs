using AuthorBookApi.DTOs;
using AuthorBookApi.Exceptions;
using AuthorBookApi.Models;
using AuthorBookApi.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Services
{
    public class AuthorDetailsService:IAuthorDetailsService
    {
        private readonly IRepository<AuthorDetails> _authorDetailsRepository;
        private readonly IMapper _mapper;
        public AuthorDetailsService(IRepository<AuthorDetails> authorDetailsRepository, IMapper mapper)
        {
            _authorDetailsRepository = authorDetailsRepository;
            _mapper = mapper;
        }
        public AuthorDetailsDto GetAuthorDetailsById(int id)
        {
            var authorDetails = _authorDetailsRepository.GetById(id);
            if (authorDetails != null)
            {
                AuthorDetailsDto authorDetailsDto = _mapper.Map<AuthorDetailsDto>(authorDetails);
                return authorDetailsDto;
            }
            throw new AuthorDetailsNotFoundException("Author Details Not found!");
        }

        public List<AuthorDetailsDto> GetAuthorDetails()
        {
            var authorDetails=_authorDetailsRepository.GetAll().ToList();
            if (authorDetails != null)
            {
                List<AuthorDetailsDto> authorDetailsDtos = _mapper.Map<List<AuthorDetailsDto>>(authorDetails);
                return authorDetailsDtos;
            }
            throw new AuthorDetailsDoesNotExistException("No author details found");
        }
        public int Add(AuthorDetailsDto authorDetailsDto)
        {
            var authorDetails=_mapper.Map<AuthorDetails>(authorDetailsDto);
            _authorDetailsRepository.Add(authorDetails);
            return authorDetails.Id;
        }
        public bool Update(AuthorDetailsDto authorDetailsDto)
        {
            var authorDetails = _mapper.Map<AuthorDetails>(authorDetailsDto);
            var existingAuthorDetails = _authorDetailsRepository.GetAll().AsNoTracking().FirstOrDefault(a => a.Id == authorDetails.Id);
            if (existingAuthorDetails != null)
            {
                _authorDetailsRepository.Update(authorDetails);
                return true;
            }
            throw new AuthorDetailsNotFoundException("Author Details not found to update");
        }
        public AuthorDetailsDto GetAuthorDetails(int id)
        {
            var authorDetails = _authorDetailsRepository.GetAll().
                Include(a => a.Author).FirstOrDefault(a => a.Id == id);
            if (authorDetails != null)
            {
                var authorDetailsDto = _mapper.Map<AuthorDetailsDto>(authorDetails);
                return authorDetailsDto;
            }
            throw new AuthorDetailsNotFoundException("Author Details not found");
        }
        public bool Delete(int id)
        {
            var existingAuthorDetails = _authorDetailsRepository.GetById(id);
            if (existingAuthorDetails != null)
            {
                _authorDetailsRepository.Delete(existingAuthorDetails);
                return true;
            }
            throw new AuthorDetailsNotFoundException("Author Details not found to delete");
        }
    }
}
