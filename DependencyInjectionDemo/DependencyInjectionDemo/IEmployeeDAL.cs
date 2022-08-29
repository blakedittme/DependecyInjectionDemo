using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemo
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
