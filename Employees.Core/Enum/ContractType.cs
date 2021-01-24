using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Employees.Core.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContractType
    {
        [EnumMember(Value = "HourlySalaryEmployee")]
        Hourly,
        [EnumMember(Value = "MonthlySalaryEmployee")]
        Monthly
    }
}
