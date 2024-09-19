using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner()
    {
        public static void Main(string[] args)
        {
            Employee.companyName = "TR";
            Employee Emp1 = new Employee();
            Employee Emp2 = new Employee();
            Employee Emp3 = new Employee();

            Emp1.EmpId = 101;
            Emp1.empName = "smith";
            Emp1.empsalary = 70000;
            Emp1.EmpPerformance = "A";

            Emp2.EmpId = 102;
            Emp2.empName = "tsmith";
            Emp2.empsalary = 90000;
            Emp2.EmpPerformance = "B";

            Emp1.DisplayEmployeeDetails();
            Emp2.DisplayEmployeeDetails();
            Emp3.DisplayEmployeeDetails();
        }
    }
    }

