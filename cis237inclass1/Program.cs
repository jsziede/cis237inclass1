using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Joshua", "Sziede", 123.45m);
            Employee employee2 = new Employee("First", "Last", 321.00m);

            int myNumber = 5;
            Console.WriteLine(myNumber);
            changeAnInt(myNumber);
            Console.WriteLine(myNumber);

            Console.WriteLine(employee1.ToString());
            changeAnObject(employee1);
            Console.WriteLine(employee1.ToString());

            //Console.WriteLine(employee.GetFullName());
            //Console.WriteLine(employee.ToString());\

            //showing how to use an array with objects
            Employee[] employees = new Employee[10];

            //instanciate some employees into the array
            employees[0] = new Employee("James", "Kirk", 453.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[4] = new Employee("Johnathan", "Archer", 394.00m);

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        //value
        static void changeAnInt(int myNumber)
        {
            myNumber = 456;
        }

        //reference
        static void changeAnObject(Employee employee)
        {
            employee.FirstName = "Thor";
        }
    }
}
