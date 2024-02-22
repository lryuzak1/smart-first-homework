using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using smart_first_homework.Entites;

namespace smart_first_homework.Database
{
    public class AddressEntityTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property<int>("Id").ValueGeneratedOnAdd();
        }
    }
}
