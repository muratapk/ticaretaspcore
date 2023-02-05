using Microsoft.EntityFrameworkCore;

namespace ticaretaspcore.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
       public DbSet<Categories> Categories { get; set; }

       public DbSet<Products> Products { get; set; }
       public DbSet<Admin> Admins { get; set; }
    }
}
