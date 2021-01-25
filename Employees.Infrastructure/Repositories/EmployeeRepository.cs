using Employees.Core.Dto;
using Employees.Core.Intefaces;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeDto>> GetEmployees(int? employeeId)
        {
            var url = "http://masglobaltestapi.azurewebsites.net/api/Employees";
            var rClient = new RestClient(url);
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "*/*");
            var restResult = await rClient.ExecuteAsync(restRequest);
            var result = JsonConvert.DeserializeObject<IEnumerable<EmployeeDto>>(restResult.Content);

            if (restResult.StatusCode != HttpStatusCode.OK
                || employeeId != null && !result.Any(x => x.id == employeeId)) return new List<EmployeeDto>();

            return employeeId != null && result.Any(x => x.id == employeeId)
                ? new List<EmployeeDto> { result.FirstOrDefault(x => x.id == employeeId) }
                : result;
        }
    }
}