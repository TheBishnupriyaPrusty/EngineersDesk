using System;
using DatabaseProject.Interfaces;
using DatabaseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EngineersDesk.Controllers
{
	[Route("api/[controller]/[Action]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeController(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		[HttpGet]
		public ActionResult GetEmployees()
		{
			try
			{
				var employees = _employeeRepository.GetEmployees();
				return Ok(employees);
			}
			catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
			}
		}

        [HttpGet]
        public ActionResult GetEmployeeById(int id)
        {
            try
            {
                var employee = _employeeRepository.GetEmployeeById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

		[HttpPost]
		public ActionResult AddEmployee(Employee employee)
		{
			try
			{
				var newEmployee = _employeeRepository.AddEmployee(employee);
				return Ok(newEmployee);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
    }
}

