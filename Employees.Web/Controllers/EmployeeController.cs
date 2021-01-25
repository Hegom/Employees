using Employees.Core.Dto;
using Employees.Core.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [HttpGet("{id?}")]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [Produces("application/json")]
        public async Task<IActionResult> GetEmployees(int? id)
        {
            try
            {
                var result = await EmployeeService.GetEmployees(id);
                if (result.Count() == 0) return NoContent();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
