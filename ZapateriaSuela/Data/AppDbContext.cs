using Microsoft.EntityFrameworkCore;
using ZapateriaSuela.Models;

namespace ZapateriaSuela.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();

        public DbSet<Venta> Ventas => Set<Venta>();

        public DbSet<DetalleVenta> DetalleVentas
            => Set<DetalleVenta>();
    }
}