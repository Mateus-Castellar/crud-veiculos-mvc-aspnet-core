using CadastroDeVeiculosEtec.Data;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeVeiculosEtec.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void AddDatabaseConfiguarations(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppVeiculosContext>(builder =>
                builder.UseSqlServer(connectionString));
        }
    }
}
