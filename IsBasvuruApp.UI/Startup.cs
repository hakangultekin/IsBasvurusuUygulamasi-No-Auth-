using IsBasvuruApp.BLL.Services.IlceService;
using IsBasvuruApp.BLL.Services.ILService;
using IsBasvuruApp.BLL.Services.PersonelBasvuruService;
using IsBasvuruApp.BLL.Services.PersonelService;
using IsBasvuruApp.CORE.IRepositories;
using IsBasvuruApp.DAL;
using IsBasvuruApp.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvuruApp.UI
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
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AppConnStr")));

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IPersonelRepository, PersonelRepository>();
            services.AddTransient<IPersonelBasvuruRepository, PersonelBasvuruRepository>();
            services.AddTransient<IIlRepository, IlRepository>();
            services.AddTransient<IIlceRepository, IlceRepository>();

            services.AddScoped<IPersonelService, PersonelService>();
            services.AddScoped<IPersonelBasvuruService, PersonelBasvuruService>();
            services.AddScoped<IILService, ILService>();
            services.AddScoped<IILceService, ILceService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
