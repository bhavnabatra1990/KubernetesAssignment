using DatabaseService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace NAGPAssignment
{
    public static class Registration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services, IConfiguration configuration)
        {
            Console.WriteLine("ASPNETCORE_ENVIRONMENT" + configuration["ASPNETCORE_ENVIRONMENT"]);

            //Console.WriteLine("GetConnectionString -" + configuration.GetConnectionString("SA_HOST"));
            //Console.WriteLine("GetConnectionString - " + configuration.GetConnectionString("SA_PORT"));
            //Console.WriteLine("GetConnectionString - " + configuration.GetConnectionString("SA_USER"));
            //Console.WriteLine("GetConnectionString - " + configuration.GetConnectionString("SA_PASSWORD"));

            var host = configuration.GetConnectionString("SA_HOST");
            var port = configuration.GetConnectionString("SA_PORT");
            var userid = configuration.GetConnectionString("SA_USER");
            var password = configuration.GetConnectionString("SA_PASSWORD");

            string connString = $"Server=tcp:{host},{port};Initial Catalog=EmployeeDb;User Id={userid};Password={password};Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=false";         
            Console.WriteLine(connString);
            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connString));
            return services;
        }
    }
}
