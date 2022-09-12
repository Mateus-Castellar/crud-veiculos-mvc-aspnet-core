using CadastroDeVeiculosEtec.Data;

namespace CadastroDeVeiculosEtec.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterDependences(this IServiceCollection services)
        {
            services.AddScoped<AppVeiculosContext>();
        }
    }
}