using System;

namespace MyFirstPrograms
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            HelloWorld.Greeting();
            Parsing.PrintUserNumber("You have written number: ");
            Console.ReadKey();
        }
    }
}
