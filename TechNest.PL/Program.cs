using Microsoft.EntityFrameworkCore;
using TechNest.BLL.AutoMapper;
using TechNest.BLL.Services.Abstraction;
using TechNest.BLL.Services.Implementation;
using TechNest.DAL.DataBase;
using TechNest.DAL.Repository.Abstraction;
using TechNest.DAL.Repository.Implementation;

namespace TechNest.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<TechNestDbContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("default"));});
            builder.Services.AddScoped<IProductRepo,ProductRepo>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
