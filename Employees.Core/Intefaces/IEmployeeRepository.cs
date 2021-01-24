using Employees.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Core.Intefaces
{
    public interface IEmployeeRepository
    {        
        IEnumerable<EmployeeDto> GetEmployee(int? employeeId);
    }
}
