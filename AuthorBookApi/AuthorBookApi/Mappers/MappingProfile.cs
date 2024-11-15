using AuthorBookApi.DTOs;
using AuthorBookApi.Models;
using AutoMapper;

namespace AuthorBookApi.Mappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Author, AuthorDto>().ForMember(x => x.TotalBooks,
                val=>val.MapFrom(src=>src.Books.Count));
            CreateMap<AuthorDto, Author>();
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<AuthorDetails, AuthorDetailsDto>();   
            CreateMap<AuthorDetailsDto, AuthorDetails>();
           
        }
    }
}
