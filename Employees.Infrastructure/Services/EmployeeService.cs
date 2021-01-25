using Employees.Core.Dto;
using Employees.Core.Intefaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository EmployeeRepository;
        private readonly IEmployeeFactory EmployeeFactory;

        public EmployeeService(IEmployeeFactory employeeFactory, IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
            EmployeeFactory = employeeFactory;
        }

        public async Task<IEnumerable<Employee>> GetEmployees(int? employeeId)
        {
            var employes = await EmployeeRepository.GetEmployees(employeeId);
            var retList = new List<Employee>();

            foreach (var employeeDto in employes)
            {
                retList.Add(EmployeeFactory.GetEmployee(employeeDto));
            }

            return retList;
        }
    }
}
