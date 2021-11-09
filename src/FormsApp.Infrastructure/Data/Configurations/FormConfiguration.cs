using FormsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormsApp.Infrastructure.Data.Configurations
{
    public class FormConfiguration : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.ToTable("form");
            
            builder.HasKey(x => x.Id);

            builder.Property(e => e.UserId).HasColumnName("userId");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Forms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__form__formId__398D8EEE");
        }
    }
}