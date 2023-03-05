using Microsoft.AspNetCore.Identity;

namespace BigSchool_4;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddDbContext<AppDbContextBigSchool>(options =>
        {
            string connectString = builder.Configuration.GetConnectionString("AppMvcConnectionString");
            options.UseSqlServer(connectString);
        });

        //đăng ký identity
        builder.Services.AddIdentity<AppUser, IdentityRole>()
        .AddEntityFrameworkStores<AppDbContextBigSchool>() //thiết lập làm việc vs csdl dựa trên dbcontext nào
        .AddDefaultTokenProviders();




        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to chansge this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

        app.Run();
        app.Run();
    }
}

