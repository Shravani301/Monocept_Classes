namespace AuthorBookApi.Exceptions
{
    public class AuthorNotFoundException:Exception
    {
        public AuthorNotFoundException(String  message) :base(message) { }
    }
}
