using AuthorBookApi.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthorBookApi.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly LibraryContext _context;
        private readonly DbSet<T> _table;
        public Repository(LibraryContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
           
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }

        public T GetById(int id)
        {
            var entity= _table.Find(id);
            return entity;
        }

        public T Update(T entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
