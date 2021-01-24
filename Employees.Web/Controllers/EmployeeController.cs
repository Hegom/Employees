using Employees.Core.Dto;
using Employees.Core.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeService EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }
        
        [HttpGet("{id?}")]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [Produces("application/json")]
        public IActionResult GetEmployees(int? id)
        {
            try
            {
                var result = EmployeeService.GetEmployees(id);
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
