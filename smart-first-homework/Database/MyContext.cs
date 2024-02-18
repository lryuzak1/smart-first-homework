using Microsoft.EntityFrameworkCore;
using smart_first_homework.Entites;

namespace smart_first_homework.Database
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = @"Data Source=DESKTOP-L387MDT\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True; MultipleActiveResultSets=True; Encrypt=false";


            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<Person>());
        }
    }
}
