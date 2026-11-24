using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAssign2.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
            builder.HasOne(x => x.Trainer).WithMany(x => x.Sessions).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("SessionCapacityConstraint", "Capacity between 1 and 25");
                t.HasCheckConstraint("SessionEndDateStartDateCheck", "EndDate > StartDate");
            });
        }
    }
}
