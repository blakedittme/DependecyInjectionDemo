using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            //Hard code employees since the scope of this console application is DI
            employees.Add(new Employee() { Id = 1, Name = "Blake1", Department = "IT"});
            employees.Add(new Employee() { Id = 2, Name = "Blake2", Department = "HR" });
            employees.Add(new Employee() { Id = 3, Name = "Blake3", Department = "Finance" });
            return employees;
        }
    }
}
