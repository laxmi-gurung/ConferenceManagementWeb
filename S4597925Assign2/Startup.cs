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
using S4597925Assign2.Controllers;
using S4597925Assign2.Data;
using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Interfaces;
using S4597925Assign2.Data.Repository;

namespace S4597925Assign2
{
    public class Startup
    {
        private const string Name = "S4597925Assign2Context";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            /**
            services.AddScoped<IOrganizerRepository, SQLOrganizerRespository>();
            services.AddScoped<IAttendeeRepository, SQLAttendeeRepository>();
            services.AddScoped<IConferenceRepository, SQLConferenceRepository>();

            services.AddDbContext<ConferenceDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConferenceDBConnection")));
            **/

            services.AddSingleton<IOrganizerRepository, OrganizerRepository>();
            services.AddSingleton<IAttendeeRepository, AttendeeRepository>();
            services.AddSingleton<IConferenceRepository, ConferenceRepository>();
   
            services.AddRazorPages();
            services.AddMvc();
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
