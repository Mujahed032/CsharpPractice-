using System;

namespace Inheritance_testing_file
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                Employee khizarEmployee = new Employee("", 111, "lecturer", EmployeeType.Lecturer);
                khizarEmployee.DescribeMe();
                Employee azharEmployee = new Employee("azhar", 222, "H.O.D", EmployeeType.Lecturer);
                azharEmployee.DescribeMe();


                Employee arifDirector = new Employee("Arif", 132, "Director", EmployeeType.Director);

                Employee.SetSalary(khizarEmployee, arifDirector, 50000.0);
                Employee.SetSalary(azharEmployee, arifDirector, 40000.0);
                Employee.SetSalary(arifDirector, arifDirector, 100000.0);

                Console.WriteLine("Write your name: ");
                string nameX = Console.ReadLine();

                if (nameX == "Arif")
                {

                    Employee.SetSalary(khizarEmployee, arifDirector, 10000.0);
                }

                Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
