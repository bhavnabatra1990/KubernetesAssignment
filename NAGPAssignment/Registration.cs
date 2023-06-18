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
            var port = configuration.GetConnectionString("SA_PORT");
            var userid = configuration.GetConnectionString("SA_USER");
            var password = configuration.GetConnectionString("SA_PASSWORD");

            string connString = "Server=sql-server-pod.applicationnamespace.svc.cluster.local,1433;Database=EmployeeDb;Persist Security Info=True;User Id=sa;Password=Welcome@0001234567;";

                //$"Server={host},{port};Database=EmployeeDb;Persist Security Info=True;User Id={userid};Password={password};";

            Console.WriteLine(connString);
            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connString));
            return services;
        }
    }
}
