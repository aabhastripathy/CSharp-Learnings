using Microsoft.EntityFrameworkCore;
using Mvc_Mugdha_Maam.Models;

namespace Mvc_Mugdha_Maam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<EmpDbContext>(options => { 
                
                options.UseSqlServer("name = connectionString");//Provider
            
            });


            var app = builder.Build();


            //Middleware
           
            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
                );

          

            app.Run();
        }
    }
}
