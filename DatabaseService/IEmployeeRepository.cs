

namespace DatabaseService
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<Employee> AddEmployee(Employee employee);

    }
}
