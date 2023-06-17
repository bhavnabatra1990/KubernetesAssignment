using DatabaseService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace NAGPAssignment
{
    public static class Registration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services, IConfiguration configuration)
        {
            var host = configuration.GetConnectionString("SA_HOST");
            var database = configuration.GetConnectionString("SA_DATABASE");
            var userid = configuration.GetConnectionString("SA_USER");
            var password = configuration.GetConnectionString("SA_PASSWORD");

            string connString = $"Server={host};Database={database};User Id=sa;Password={password};";
            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connString));
            return services;
        }
    }
}
