using Employees.Core.Dto;
using Employees.Core.Enum;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeFactory
    {
        Employee GetEmployee(EmployeeDto employee);
    }
}
