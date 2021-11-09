using System.Collections.Generic;
using System.Threading.Tasks;
using FormsApp.Domain.Entities.Base;

namespace FormsApp.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        void Update(T entity);
        Task Delete(int id);
        Task<bool> Exists(int id);
    }
}