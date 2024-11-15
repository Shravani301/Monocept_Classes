using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorBookApi.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

    }
}
