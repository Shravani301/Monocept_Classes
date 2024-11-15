using AuthorBookApi.Models;

namespace AuthorBookApi.Repositories
{
    public interface IAuthorDetailsRepository
    {
        public List<AuthorDetails> GetAuthorDetails();
        public AuthorDetails GetAuthorDetailsById(int id);
        public int Add(AuthorDetails authorDetails);
        public int Update(AuthorDetails authorDetails);
        public void Delete(AuthorDetails authorDetails);
    }
}
