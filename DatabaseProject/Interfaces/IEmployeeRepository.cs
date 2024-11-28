using System;
using DatabaseProject.Models;

namespace DatabaseProject.Interfaces
{
	public interface IEmployeeRepository
	{
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        Employee AddEmployee(Employee employee);
    }
}

