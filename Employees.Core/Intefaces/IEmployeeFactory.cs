using Employees.Core.Dto;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeFactory
    {
        Employee GetEmployee(EmployeeDto employee);
    }
}
