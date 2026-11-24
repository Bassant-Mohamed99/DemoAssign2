using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;

namespace DemoAssign2.Configurations
{
    public class MemberShipConfigurations:IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
            builder.HasOne(x => x.Plan).WithMany(x => x.MemberShips).HasForeignKey(x => x.PlanId).OnDelete(DeleteBehavior.Restrict);
          
        }
    
    }
}
