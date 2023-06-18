using DatabaseService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace NAGPAssignment
{
    public static class Registration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services, IConfiguration configuration)
        {
            Console.WriteLine(configuration["ASPNETCORE_ENVIRONMENT"]);
            Console.WriteLine(configuration["ConnectionStrings__SA_HOST"]);
            var host = configuration.GetConnectionString("SA_HOST");

            var port = configuration.GetConnectionString("SA_PORT");
            var userid = configuration.GetConnectionString("SA_USER");
            var password = configuration.GetConnectionString("SA_PASSWORD");
            //"Server=tcp:sql-server-pod.applicationnamespace.svc.cluster.local,1433;Database=EmployeeDb;Persist Security Info=True;User Id=sa;Password=Welcome@0001234567;";
            //tcp:34.70.101.64,1433
            string connString = $"Server=tcp:mssql-0.applicationnamespace.svc.cluster.local;Initial Catalog=EmployeeDb;User Id=sa;Password=Welcome@0001234567;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=false";
            //string connString = $"Server=tcp:{host},{port};Initial Catalog=EmployeeDb;Persist Security Info=False;User Id={userid};Password={password};TrustServerCertificate=False;Connection Timeout=30;";

            Console.WriteLine(connString);
            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connString));
            return services;
        }
    }
}
