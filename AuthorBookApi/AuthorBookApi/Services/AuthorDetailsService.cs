﻿using AuthorBookApi.DTOs;
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
            AuthorDetailsDto authorDetailsDto=_mapper.Map<AuthorDetailsDto>(authorDetails);
            return authorDetailsDto;
        }

        public List<AuthorDetailsDto> GetAuthorDetails()
        {
            var authorDetails=_authorDetailsRepository.GetAll().ToList();
            List<AuthorDetailsDto> authorDetailsDtos=_mapper.Map<List<AuthorDetailsDto>>(authorDetails);
            return authorDetailsDtos;
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
            return false;

        }
        public bool Delete(int id)
        {
            var existingAuthorDetails = _authorDetailsRepository.GetById(id);
            if (existingAuthorDetails != null)
            {
                _authorDetailsRepository.Delete(existingAuthorDetails);
                return true;
            }
            return false;
        }
    }
}