using RollingSun_API;
using System.Threading.RateLimiting;

namespace RollingSun {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<DBreader>();
            builder.Services.AddScoped<DataManager>();
            builder.Services.AddScoped<IHostEnvironment>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            }
        }
    }
