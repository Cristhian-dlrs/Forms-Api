using FormsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormsApp.Infrastructure.Data.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("answer");
            
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.QuestionId).HasColumnName("questionId");

            builder.Property(e => e.RespondantId).HasColumnName("respondantId");

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");

            builder.HasOne(d => d.Question)
                .WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__answer__question__4222D4EF");

            builder.HasOne(d => d.Respondant)
                .WithMany(p => p.Answers)
                .HasForeignKey(d => d.RespondantId)
                .HasConstraintName("FK__answer__responda__4316F928");
        }
    }
}