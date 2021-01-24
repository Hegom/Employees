using Employees.Core.Enum;

namespace Employees.Core.Dto
{
    public abstract class Employee
    {
        protected Employee(int id, string name, ContractType contractTypeName, int roleId, string roleName, string roleDescription, decimal hourlySalary, decimal monthlySalary)
        {
            Id = id;
            Name = name;
            ContractTypeName = contractTypeName.ToString();
            RoleId = roleId;
            RoleName = roleName;
            RoleDescription = roleDescription;
            HourlySalary = hourlySalary;
            MonthlySalary = monthlySalary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public abstract decimal AnnualSalary { get; }        
    }
}
