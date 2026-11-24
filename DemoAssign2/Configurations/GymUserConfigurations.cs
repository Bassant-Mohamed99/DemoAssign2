using DemoAssign2.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAssign2.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("GymUserCheck_EmailCheck", "Email Like '_@_%._' ");
                t.HasCheckConstraint("GymUserCheck_PhoneCheck", "Len(Phone) = 11 And(phone like '010%' or phone like '011%' or phone like '012%' or phone like '015%' )");

            });
        }
    }
}
