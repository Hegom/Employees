using Employees.Core.Dto;
using Employees.Core.Intefaces;
using System.Collections.Generic;

namespace Employees.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository EmployeeRepository;
        public IEmployeeFactory EmployeeFactory;

        public EmployeeService(IEmployeeFactory employeeFactory, IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
            EmployeeFactory = employeeFactory;
        }

        public IEnumerable<Employee> GetEmployees(int? employeeId)
        {
            var employes = EmployeeRepository.GetEmployee(employeeId);

            foreach (var employeeDto in employes)
            {
                yield return EmployeeFactory.GetEmployee(employeeDto);
            }
        }
    }
}
