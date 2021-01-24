using Employees.Core.Enum;

namespace Employees.Core.Dto
{
    public class MonthlyEmployee : Employee
    {
        public MonthlyEmployee(int id, string name, ContractType contractTypeName, int roleId, string roleName, string roleDescription, decimal hourlySalary, decimal monthlySalary)
            : base(id, name, contractTypeName, roleId, roleName, roleDescription, hourlySalary, monthlySalary)
        {

        }

        public override decimal AnnualSalary => MonthlySalary * 12;
    }
}
