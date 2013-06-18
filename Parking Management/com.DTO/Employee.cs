using System;

namespace Parking_Management.com.DTO
{
    class Employee
    {
        public Employee(int employeeId, int employeeName, string employeeSsn, string password)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeSsn = employeeSsn;
            Password = password;
        }

        private int EmployeeId { get; set; }

        private int EmployeeName { get; set; }

        private String EmployeeSsn { get; set; }
        
        private String Password { get; set; }
    }
}
