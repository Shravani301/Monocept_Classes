﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorBookApi.DTOs
{
    public class AuthorDetailsDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}
