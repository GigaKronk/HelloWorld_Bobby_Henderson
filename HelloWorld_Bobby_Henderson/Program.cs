using System;

namespace HelloWorld_Bobby_Henderson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Hello,{firstname} {lastname}!");
        }
    }
}
