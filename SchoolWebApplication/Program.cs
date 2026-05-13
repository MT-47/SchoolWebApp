using Helper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Task_001;

namespace SchoolWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(s =>
            {
                s.SignIn.RequireConfirmedEmail = false;
                //s.Lockout.AllowedForNewUsers = true;
                //s.Lockout.MaxFailedAccessAttempts = 5;
            })
                .AddEntityFrameworkStores<ITIContext>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ITIContext>(d =>
            {
                d.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IEntityRepo<Department>, EntityRepo<Department>>();
            builder.Services.AddScoped<IEntityRepo<Student>, StudentRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}