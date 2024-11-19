namespace EmployeeWithGuid.Repositories
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public T GetById(Guid id);
        public IQueryable<T> GetAll();
    }
}
