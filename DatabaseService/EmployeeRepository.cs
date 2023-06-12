
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DatabaseService
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            _employeeDbContext.Employee.Add(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _employeeDbContext.Employee.ToListAsync();

        }

       

    }
}
