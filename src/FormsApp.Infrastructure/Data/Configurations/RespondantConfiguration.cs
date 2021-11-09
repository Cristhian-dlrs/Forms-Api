using FormsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormsApp.Infrastructure.Data.Configurations
{
    public class RespondantConfiguration : IEntityTypeConfiguration<Respondant>
    {
        public void Configure(EntityTypeBuilder<Respondant> builder)
        {
            builder.ToTable("respondant");
            
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.FormId).HasColumnName("formId");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            builder.HasOne(d => d.Form)
                .WithMany(p => p.Respondants)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK__respondan__formI__3F466844");
        }
    }
}