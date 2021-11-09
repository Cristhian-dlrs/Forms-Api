using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Domain.Entities.Base;
using FormsApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FormsApp.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly FormsApp_dbContext _dbContext;
        private DbSet<T> _db;

        public GenericRepository(FormsApp_dbContext dbContext)
        {
            _dbContext = dbContext;
            _db = _dbContext.Set<T>();
        }

        public async Task<T> Get(int id)
        {
            return await _db.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.AsNoTracking().ToListAsync();
        }

        public async Task<T> Add(T entity)
        {
            await _db.AddAsync(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);
            _db.Remove(entity);
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }
    }
}