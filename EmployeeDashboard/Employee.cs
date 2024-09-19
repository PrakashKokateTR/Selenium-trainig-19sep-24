using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int EmpID;
        public string empName;
        public double empsalary;
       private string empPerformance;
        public static string companyName;

        public int EmpId
        {
            get
            {
                return EmpID;
            }
            set
            {
                if (EmpID != 100)
                {
                    EmpID = value;
                }
                else
                {
                    console.writeline("currently employee id=0.Please provide value more than 100");
                }
            }
        }

        public string EmpPerformance
        {
            get
            {
                return EmpPerformance;
            }
            set{
                if (EmpPerformance= "A")
            {
                    EmpPerformance = value;
                }
           
               
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID:" + EmpID);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empsalary);
            Console.WriteLine("Employee Performance:" + empPerformance);
            Console.WriteLine("Company Name:"+Employee.companyName);
            Console.WriteLine("--------------------------------------");


            


        }
        //Allocate bonus
        public void AllocateBonus()
        {
            if (empPerformance != null)
            {
                if (empPerformance.Equals("A"))
                {
                    empsalary = empsalary + 1000;
                }
            else if (empPerformance.Equals("B"))

                {
                    empsalary = empsalary + 500;

                }
                else
                {
                    empsalary = empsalary + 100;
                }
            


        

