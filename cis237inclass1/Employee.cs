using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee //noun class
    {
        //fields
          //use private variables
        private string firstName;
        private string lastName;
        private decimal weeklySalary; //use decimal when working with finance

        //properties
          //use public variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("C");
        }

        //method
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        //3 parameter constructor
        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            //assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;

            //assign the passed in value by the property
            this.WeeklySalary = weeklySalary;
        }

        //default constructor
        public Employee()
        {
            //let's just leave this blank
        }
    }
}
