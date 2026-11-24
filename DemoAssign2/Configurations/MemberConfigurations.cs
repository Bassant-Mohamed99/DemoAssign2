using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAssign2.Configurations
{
    public class MemberConfigurations:GymUserConfigurations<Member>,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt).HasColumnName("joinDate").HasDefaultValueSql("getdate()");

            base.Configure(builder);

        }
    }
}
