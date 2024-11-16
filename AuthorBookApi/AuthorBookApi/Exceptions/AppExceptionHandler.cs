using AuthorBookApi.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace AuthorBookApi.Exceptions
{
    public class AppExceptionHandler:IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
            Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse();
            if (exception is AuthorNotFoundException)
            {
                response.StatusCode = StatusCodes.Status404NotFound;
                response.ExceptionMessage = exception.Message;
                response.Title = "Wrong Input";
            }
            else if (exception is AuthorDetailsNotFoundException)
            {
                response.StatusCode = StatusCodes.Status404NotFound;
                response.ExceptionMessage = exception.Message;
                response.Title = "Wrong Input";
            }
            else if (exception is BookNotFoundException)
            {
                response.StatusCode = StatusCodes.Status404NotFound;
                response.ExceptionMessage = exception.Message;
                response.Title = "Wrong Input";
            }
            else if (exception is BooksDoesNotExistException)
            {
                response.StatusCode = StatusCodes.Status204NoContent;
                response.ExceptionMessage = exception.Message;
                response.Title = "No books found";
            }
            else if (exception is AuthorsDoesNotExistException)
            {
                response.StatusCode = StatusCodes.Status204NoContent;
                response.ExceptionMessage = exception.Message;
                response.Title = "No authors found";
            }
            else if (exception is AuthorDetailsDoesNotExistException)
            {
                response.StatusCode = StatusCodes.Status204NoContent;
                response.ExceptionMessage = exception.Message;
                response.Title = "No AuthorDetails found";
            }
            else
            {
                response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ExceptionMessage = exception.Message;
                response.Title = "Something went wrong!";
            }
            await httpContext.Response.WriteAsJsonAsync(response,cancellationToken);
            return true;
        }
    }
}
