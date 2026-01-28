using Microsoft.EntityFrameworkCore;

namespace KaShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            //
            optionsBuilder.UseSqlServer("Server=db39105.public.databaseasp.net; Database=db39105; User Id=db39105; Password=Zk4=6-aYjG+7; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ");

            //Database for dev
            //optionsBuilder.UseSqlServer("Server=.;Database=mvc_13;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
