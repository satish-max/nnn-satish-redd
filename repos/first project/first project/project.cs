using System;
using System.Collections.Generic;
using System.Text;

namespace first_project
{
    class project
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string departmentName = emp.GetDepName();
            string employeeName = emp.GetEmpName();
            Console.WriteLine(employeeName + "belongs to " + departmentName);
        }
    }
}
