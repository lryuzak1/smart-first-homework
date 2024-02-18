using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using smart_first_homework.Entites;

namespace smart_first_homework.Database
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasOne(x => x.Address).WithOne(x => x.Person);
            builder.HasMany(x => x.PhoneNumbers).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);
            builder.HasMany(x => x.Emails).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);
            builder.HasMany(x => x.Events).WithMany(x => x.Persons).UsingEntity("PersonEvent");
        }
    }
}
