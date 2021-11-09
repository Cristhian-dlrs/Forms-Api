using FormsApp.Domain.Entities;
using FormsApp.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FormsApp.Infrastructure.Data
{
    public class FormsApp_dbContext : DbContext
    {
        public FormsApp_dbContext()
        {
        }

        public FormsApp_dbContext(DbContextOptions<FormsApp_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Respondant> Respondants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FormConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new RespondantConfiguration());
        }
    }
}
 