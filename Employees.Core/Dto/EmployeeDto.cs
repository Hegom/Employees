using Employees.Core.Enum;

namespace Employees.Core.Dto
{
    public class EmployeeDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public ContractType contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
    }
}
