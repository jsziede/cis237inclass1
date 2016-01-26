using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        ///no need for local variables, so there are no private variable
        ///declarations for this class and no need for properties

        //public methods - we will have some of these

        ///this will print the menu to the screen, and await a valid input
        ///from the user. Once the input is valid, it will return the number
        ///that they selected
        public int GetUserInput()
        {
            //print the menu first
            this.printMenu();

            //get user input from the terminal
            //stores the user input as a string
            string input = Console.ReadLine();

            //while the input is NOT a valid answer
            while (input != "1" && input != "2")
            {
                Console.WriteLine("Invalid entry.");
                Console.WriteLine("Please select an option.");
                Console.WriteLine();
                //reprint the menu for the user
                this.printMenu();
                //store the user's next input from the console
                input = Console.ReadLine();
            }

            //due to the while loop, we know that it can only be exited if the user input
            //a valid response, so we do not need a try/catch (although we could if we wanted to)
            return Int32.Parse(input);
        }

        //take in a string that we would like to output to the screen
        public void PrintAllOuput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        //this is just a private method to print out the 
        //Menu. It will probably happen quite a bit, so it makes sense that it is in a method
        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        //constructors -  no need for any constructors
        //we will use automatic constructors
    }
}
