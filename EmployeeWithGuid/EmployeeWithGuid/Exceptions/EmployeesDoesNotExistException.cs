namespace EmployeeWithGuid.Exceptions
{
    public class EmployeesDoesNotExistException:Exception
    {
        public EmployeesDoesNotExistException(string  message) : base(message) { }
    }
}
