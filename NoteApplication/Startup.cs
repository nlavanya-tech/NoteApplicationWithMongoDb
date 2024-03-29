using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using NoteApplication.BusinessLogics.Interface;
using NoteApplication.BusinessLogics.Services;
using NoteApplication.BusinessLogics.Services.Repository;
using NoteApplication.Database;
using NoteApplication.DataLayer;
using NoteApplication.DataLayer.Context;
using NoteApplication.Models;

namespace NoteApplication
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
            services.AddMvc();
            services.AddDbContext<InMemoryDb>(options => options.UseInMemoryDatabase("InMemoryDB"));
            services.Configure<MongoDbSetting>(sp => 
            { sp.ConnectionString = Configuration.GetSection("NotesDatabaseSettings:ConnectionString").Value;
              sp.Database = Configuration.GetSection("NotesDatabaseSettings:Database").Value;
            });
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<IMongoDbContext, MongoDbContext>();

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
