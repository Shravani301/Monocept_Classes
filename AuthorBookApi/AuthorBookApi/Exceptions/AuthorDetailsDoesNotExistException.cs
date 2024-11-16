namespace AuthorBookApi.Exceptions
{
    public class AuthorDetailsDoesNotExistException:Exception
    {
        public AuthorDetailsDoesNotExistException(string message):base(message) { }
    }
}
