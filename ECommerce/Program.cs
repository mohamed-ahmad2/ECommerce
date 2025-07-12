using ECommerce.Data; 
using ECommerce.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore; 


namespace ECommerce
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            #region AddDefaultIdentity
            //builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = false;
            //})
            //.AddEntityFrameworkStores<ApplicationDbContext>();
            #endregion

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
            #region optionally
            /*options =>
        {
            // Password
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 6;
            options.Password.RequireUppercase = false;

            //Lock after incorrect attempts
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

            // Log in
            options.SignIn.RequireConfirmedAccount = true; // If you use email confirmation
        }*/
            #endregion
            )
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();


            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication();
            builder.Services.AddAuthentication()
            .AddGoogle(options =>
            {
                options.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;

      
                options.Scope.Add("profile");
                options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
            });



            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                await IdentitySeedData.SeedRolesAsync(services);
                await IdentitySeedData.SeedAdminUserAsync(services);
            }

            app.Run();

            
        }
    }
}
