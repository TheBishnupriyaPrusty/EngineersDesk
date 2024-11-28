using System;
namespace DatabaseProject.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
        public string ? EmployeeName { get; set; }
        public string ? City { get; set; }
        public DateTime DateOfJoining { get; set; }
		public Decimal Salary { get; set; }
	}
}

