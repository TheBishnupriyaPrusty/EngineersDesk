using System;
using DatabaseProject.DatabaseContext;
using DatabaseProject.Interfaces;
using DatabaseProject.Models;

namespace DatabaseProject.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public EmployeeRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;

        }

        public Employee AddEmployee(Employee employee)
        {
            _sqlServerContext.Employee.Add(employee);
            _sqlServerContext.SaveChanges();
            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _sqlServerContext.Employee.FirstOrDefault(x => x.EmployeeId == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            var listEmployees = _sqlServerContext.Employee.ToList();
            return listEmployees;
        }
    }
}

