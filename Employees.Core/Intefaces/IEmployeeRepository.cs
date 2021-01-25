using Employees.Core.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeRepository
    {        
        Task<IEnumerable<EmployeeDto>> GetEmployees(int? employeeId);
    }
}
