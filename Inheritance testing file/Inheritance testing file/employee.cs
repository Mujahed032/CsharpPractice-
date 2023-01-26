using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_testing_file
{
    internal class Employee : Person
    {

        public EmployeeType Type { get; set; }
     

        public double Salary
        {
            get; set;
        }

        public string Designation;
        public Employee(string name, int id,  string designation, EmployeeType type) : base(name, id)
        { 
                 
            this.Designation = designation;
            this.Type = type;

        }

        public override void DescribeMe()
        {
            Console.WriteLine($"employee name is: {FirstName} And his desgination is {Designation}");
            Console.WriteLine("employee id is: "+id);
           
        }

        public static void SetSalary(Employee employeeX, Employee settingEmployee, double salary)
        {
            if (settingEmployee.Type == EmployeeType.Director)
                employeeX.Salary = salary;
            else
            {
               Console.WriteLine("This employee is not authorized to set salary information.");
                
            }
        }

        public static double GetSalary(Employee employeeX, Employee queryingEmployee)
        {
        if (queryingEmployee.Type == EmployeeType.Director)
            return employeeX.Salary;
        else
        {
          Console.WriteLine("This employee is not authorized to get salary information.");
            return 0;
        }
        }

        }
}
