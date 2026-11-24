using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;

namespace DemoAssign2.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plans>
    {
     public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plans> builder)
        {
           builder.Property(x=> x.CreatedAt).HasDefaultValueSql("getdate()");
            builder.ToTable(t =>
            {
             t.HasCheckConstraint("PlanDurationCheck", "DurationDays between 1 and 365");
            });
        }
    }
}
