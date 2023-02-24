// System namespace needed to use Console class.
using System;

// My collection of classe for this project.
namespace HelloWorld_Bobby_Henderson
{   // Main class for our program
    class Program
    {   
        // The Main method is executed when application starts
        static void Main(string[] args)
        {   // Asks the user for first name
            Console.WriteLine("What is your first name");
            //Assign the user input to firstName variable
            string firstname = Console.ReadLine();
            //Ask the user for last name
            Console.WriteLine("what is your last name?");
            //Assign the user input to lastName variable
            string lastname = Console.ReadLine();

            //prints a welcome message with firstname and lastname
            Console.WriteLine($"Hello,{firstname} {lastname}!");
        }
    }
}
