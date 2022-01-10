using Microsoft.EntityFrameworkCore;

namespace Mathematics.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData
                (
                new Person { Id = 1, Name = "Ruzimurod", Email = "Ruzimurodabdunazarov@gmail.com", Birth = DateTime.Parse("23-11-2003"), Login = "Ruzimurod03", Password = "P@ssvv0rd", Role = Role.Administrator },
                new Person { Id = 2, Name = "Huranna", Email = "DilnerHuran@gmail.com", Birth = DateTime.Parse("16-05-1997"), Login = "Hurnur42", Password = "RuzN22s", Role = Role.User },
                new Person { Id = 3, Name = "Nigina", Email = "Niginochka@gmail.com", Birth = DateTime.Parse("16-03-2003"), Login = "Nigi32", Password = "Od4er36g", Role = Role.TestCompiler }
                );
        }
    }
}
