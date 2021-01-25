using Employees.Core.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees(int? employeeId);
    }
}
