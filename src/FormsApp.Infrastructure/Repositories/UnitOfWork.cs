using System;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Domain.Entities;
using FormsApp.Infrastructure.Data;

namespace FormsApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FormsApp_dbContext _dbContext;
        private GenericRepository<User> _users;
        private IFormsRepository _forms;
        private IGenericRepository<Question> _questions;
        private IGenericRepository<Answer> _answers;
        private IGenericRepository<Respondant> _respondants;

        public UnitOfWork(FormsApp_dbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IGenericRepository<User> Users => _users ??= new GenericRepository<User>(_dbContext);

        public IFormsRepository Forms => _forms ??= new FormsRepository(_dbContext);

        public IGenericRepository<Question> Questions =>
            _questions ??= new GenericRepository<Question>(_dbContext);

        public IGenericRepository<Answer> Answers =>
            _answers ??= new GenericRepository<Answer>(_dbContext);

        public IGenericRepository<Respondant> Respondants =>
            _respondants ??= new GenericRepository<Respondant>(_dbContext);

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}