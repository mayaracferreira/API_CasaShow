using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using CasaShow.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CasaShow
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddDbContext<ApplicationsDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationsDbContext>();
            
            services.AddControllersWithViews();
           services.AddRazorPages();

            services.AddSwaggerGen(config => {
                config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {Title= "API CASA SHOW ", Version ="v1"});
            });

            }

            /*services.AddDefaultIdentity<IdentityUser>(config => {
                config.Password.RequireNonAlphanumeric = true;
                config.Password.RequireUppercase = false;
                config.Password.RequireLowercase = false;

            
        });*/

    
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
                  
            app.UseSwagger(config => {
            config.RouteTemplate ="CasaShow/{documentName}/swagger.json";
            });

            app.UseSwaggerUI(config => {
            config.SwaggerEndpoint("/CasaShow/v1/swagger.json","v1 docs");
            });
            

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            
        }
    }
}
