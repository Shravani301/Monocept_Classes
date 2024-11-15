﻿using AuthorBookApi.Models;

namespace AuthorBookApi.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }        
        public int TotalBooks { get; set; }
    }
}