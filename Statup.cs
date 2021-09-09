using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace fiapweb
{
    public class Statup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                //localhost:5001/produtos/oferta/teclados
                //endpoints.MapControllerRoute(
                //   name: "alunos",
                //   pattern: "alunos/{action=Index}/{id?}",
                //   //pattern: "{controller}/{action}/{id?}",
                //   defaults: new { controller = "Secretaria" }
                //   );

                //endpoints.MapControllerRoute(
                // name: "categoriadeprodutos",
                // pattern: "produtos/oferta/{categoria}/{id?}",
                // //pattern: "{controller}/{action}/{id?}",
                // defaults: new { controller = "Oferta", action ="Index" }
                // );

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    //pattern: "{controller}/{action}/{id?}",
                    //defaults: new {controller="Home", action = "Index"}
                    );


                
            });


            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("Boa noite o/");
            //});

        }
    }
}