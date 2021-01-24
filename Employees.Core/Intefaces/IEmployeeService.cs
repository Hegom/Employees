using Employees.Core.Dto;
using System.Collections.Generic;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees(int? employeeId);
    }
}
