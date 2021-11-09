using System;
using System.Threading.Tasks;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> Users { get; }
        IFormsRepository Forms { get; }
        IGenericRepository<Question> Questions { get; }
        IGenericRepository<Answer> Answers { get; }
        IGenericRepository<Respondant> Respondants { get; }
        Task Save();
    }
}