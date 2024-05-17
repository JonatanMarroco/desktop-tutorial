using Microsoft.EntityFrameworkCore;
using tupenca.Business.Domain;
using tupenca.Common.Types;

namespace tupenca.Business.Persistence
{
    public sealed class DataContext : DbContext
    {
        public DbSet<Sitio> Sitio { get; set; } = default!;
        public DbSet<Usuario> Usuario { get; set; } = default!;
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}