﻿namespace AuthorBookApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book>? Books { get; set; }
        public AuthorDetails? AuthorDetails { get; set; }

    }
}
