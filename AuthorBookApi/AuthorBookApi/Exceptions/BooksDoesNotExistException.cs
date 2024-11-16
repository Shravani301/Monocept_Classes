namespace AuthorBookApi.Exceptions
{
    public class BooksDoesNotExistException:Exception
    {
        public BooksDoesNotExistException(string message):base(message) { }
    }
}
