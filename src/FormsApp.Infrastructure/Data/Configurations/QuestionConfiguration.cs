using FormsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormsApp.Infrastructure.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("question");
            
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.FormId).HasColumnName("formId");

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");

            builder.HasOne(d => d.Form)
                .WithMany(p => p.Questions)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK__question__formId__3C69FB99");
        }
    }
}