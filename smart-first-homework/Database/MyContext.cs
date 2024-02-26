using Microsoft.EntityFrameworkCore;
using smart_first_homework.Entites;

namespace smart_first_homework.Database
{
    public class MyContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = @"Data Source=DESKTOP-L387MDT\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True; MultipleActiveResultSets=True; Encrypt=false";


            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<Person>());
            new AddressEntityTypeConfiguration().Configure(modelBuilder.Entity<Address>());
        }
    }
}
