using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository( ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var addEntity = await _context.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var removeEntity = await _context.Set<TEntity>().FindAsync(id);
            _context.Remove(removeEntity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var getAll = await _context.Set<TEntity>().ToListAsync();
            return getAll;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var getById = await _context.Set<TEntity>().FindAsync(id);
            return getById;

        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsExistAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            return entity != null;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updateEntity = _context.Update(entity);
            return entity;
        }
    }
}
