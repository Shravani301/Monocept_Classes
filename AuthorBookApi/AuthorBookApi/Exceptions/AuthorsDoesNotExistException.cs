namespace AuthorBookApi.Exceptions
{
    public class AuthorsDoesNotExistException:Exception
    {
        public AuthorsDoesNotExistException(string message):base(message) { }
    }
}
