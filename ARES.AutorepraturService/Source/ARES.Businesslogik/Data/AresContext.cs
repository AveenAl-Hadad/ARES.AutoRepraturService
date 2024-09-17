using Microsoft.EntityFrameworkCore;
using ARES.Businesslogik.Models;


namespace ARES.WebApi.Data
{
    public class AresContext : DbContext
    {
        public DbSet<Termin> Termine { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Schaden> Schäden { get; set; }
        public DbSet<Autohalter> Autohalter { get; set; }

        public AresContext(DbContextOptions<AresContext> options)
            : base(options) { }
    }
}
