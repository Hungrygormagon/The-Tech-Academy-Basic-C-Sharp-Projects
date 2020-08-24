using System;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.employeeID = 1;
            employee1.SayName();
        }
    }
}
