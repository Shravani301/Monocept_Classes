using AuthorBookApi.Models;

namespace AuthorBookApi.Repositories
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
        public Author GetAuthorById(int id);
        public int Add(Author author);
        public int Update(Author author);
        public void Delete(Author author);
    }
}
