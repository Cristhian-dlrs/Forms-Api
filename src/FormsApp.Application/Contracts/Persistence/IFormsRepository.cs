using System.Threading.Tasks;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Contracts.Persistence
{
    public interface IFormsRepository : IGenericRepository<Form>
    {
        Task<Form> GetFormWithQuesitons(int id);
    }
}