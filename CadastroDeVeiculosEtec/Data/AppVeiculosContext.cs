using CadastroDeVeiculosEtec.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeVeiculosEtec.Data
{
    public class AppVeiculosContext : DbContext
    {
        public AppVeiculosContext(DbContextOptions<AppVeiculosContext> context) : base(context)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Veiculo>? Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppVeiculosContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
