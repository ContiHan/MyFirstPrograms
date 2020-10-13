using System;

namespace MyFirstPrograms
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            HelloWorld.Greeting();
            Parsing.PrintUserNumber();
            Parsing.PrintUserNumber("You have written number: ");
            HelloWorld.Greeting();
            Console.ReadKey();
        }
    }
}
