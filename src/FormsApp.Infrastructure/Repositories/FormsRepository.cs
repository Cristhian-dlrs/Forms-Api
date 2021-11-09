using System.Linq;
using System.Threading.Tasks;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Domain.Entities;
using FormsApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FormsApp.Infrastructure.Repositories
{
    public class FormsRepository : GenericRepository<Form>, IFormsRepository
    {
        private readonly FormsApp_dbContext _dbContext;
        
        public FormsRepository(FormsApp_dbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Form> GetFormWithQuesitons(int id)
        {
            return await _dbContext.Forms
                .Include(x => x.Questions)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}