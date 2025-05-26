using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using EmployeesApp.Application;
using EmployeesApp.Infrastructure;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddTransient<EmployeeService>();
            //builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
            // builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            builder.Services.AddTransient<IEmployeeService, EmployeeService>();
            builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<MyLogServiceFilterAttribute>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}