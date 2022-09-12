namespace CadastroDeVeiculosEtec.Configuration
{
    public static class MvcConfiguration
    {
        public static void AddMvcConfiguration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(Program));
        }

        public static void UseMvcConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment() is false)
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Veiculos}/{action=Index}/{id?}");
        }
    }
}
