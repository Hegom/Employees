using Employees.Core.Dto;
using Employees.Core.Enum;
using Employees.Core.Intefaces;
using System;

namespace Employees.Infrastructure.Services
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee GetEmployee(EmployeeDto employee) =>
            employee.contractTypeName switch
            {
                ContractType.Hourly => new HourlyEmployee(employee.id, employee.name, employee.contractTypeName, employee.roleId, employee.roleName, employee.roleDescription, employee.hourlySalary, employee.monthlySalary),
                ContractType.Monthly => new MonthlyEmployee(employee.id, employee.name, employee.contractTypeName, employee.roleId, employee.roleName, employee.roleDescription, employee.hourlySalary, employee.monthlySalary),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(employee.contractTypeName)),
            };
    }
}
