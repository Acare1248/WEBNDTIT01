using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebNDTIT01.Models;
using WebNDTIT01.services;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace WebNDTIT01
{
    public class Startup
    {
         public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            LDAPUtil.Register(Configuration);

           
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            var connectionString = "Server=10.0.0.51;User=ndtuser;Password=NDTuser@1234;Database=ndt_db";
            //var connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    /*.AddEntityFrameworkStores<ApplicationDbContext>();*/
                    .AddEntityFrameworkStores<ndt_dbContext>();
            services.AddControllersWithViews();

            services.AddDbContext<ndt_dbContext>(
                options => options
                .UseMySql(connectionString, serverVersion)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
            );
            //services.AddControllers();

                //services.AddEntityFrameworkMySql()
                //.AddDbContext<ndt_dbContext>(
            /*services.AddDbContext<ndt_dbContext>(
                DbContextOptions => DbContextOptions
                //options => options
                .UseMySql(Configuration.GetConnectionString("DefaultConnection"),serverVersion)
                //.UseMySql(connectionString,serverVersion)
                //.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], serverVersion)
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
            );*/
           
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(config =>
                {
                    config.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                    config.Cookie.MaxAge = config.ExpireTimeSpan;
                    config.SlidingExpiration = true;
                    config.LoginPath = "/Account/Login/"; 
                    config.AccessDeniedPath = "/Account/AccessDenied/"; 
                });
         }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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
