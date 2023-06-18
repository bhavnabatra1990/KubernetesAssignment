using DatabaseService;
using Microsoft.AspNetCore.Mvc;
using NAGPAssignment.Models;

namespace NAGPAssignment.Controllers
{
    [ApiController]
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(ILogger<EmployeeController> logger, IConfiguration configuration,IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResponse>>> Get()
        {
            try
            {
                List<EmployeeResponse> employeeResponses = new List<EmployeeResponse>();
                var employees = await _employeeRepository.GetEmployeesAsync();
                //for each loop in employees list and add item into employeeResponses list
                foreach (var employee in employees)
                {
                    employeeResponses.Add(new EmployeeResponse { Address = employee.Address, Id = employee.Id, FirstName = employee.FirstName, LastName = employee.LastName, PhoneNumber = employee.PhoneNumber, Salary = employee.Salary });
                }
                return Ok(employeeResponses.ToArray());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting employees");
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(EmployeeResponse employeeResponse)
        {
            try
            {
                Employee employeeResponses = new Employee { Address = employeeResponse.Address, 
                    FirstName = employeeResponse.FirstName, LastName = employeeResponse.LastName,
                    PhoneNumber = employeeResponse.PhoneNumber, Salary = employeeResponse.Salary };
                var data = await _employeeRepository.AddEmployee(employeeResponses);

                return Ok(data.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting employees");
                return StatusCode(500, ex.Message);
            }

        }
    }
}