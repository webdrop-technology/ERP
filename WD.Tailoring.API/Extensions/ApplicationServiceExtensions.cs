using Microsoft.EntityFrameworkCore;
using WD.Tailoring.Core.Interfaces;
using WD.Tailoring.Core.Services;
using WD.Tailoring.Infrastructure.Data;

namespace WD.Tailoring.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
         IConfiguration config)
        {
            // Add services to the container.
            services.AddControllers();

            //Add SQLite DbContext   (0)
            services.AddDbContext<TailoringContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            // Add SQL Server DbContext
            // services.AddDbContext<TailoringContext>(opt =>
            // {
            //     opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            // });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            //Adding CORS 
            services.AddCors(); //(2)

            //Inject Dependencies (3)
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}