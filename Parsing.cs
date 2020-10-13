using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPrograms
{
    class Parsing
    {
        static double GetUserInput()
        {
            double UserNumber;
            do
            {
                TextForUserToGetNumber();
            } while (double.TryParse(Console.ReadLine(), out UserNumber) == false);
            return UserNumber;
        }

        static public void PrintUserNumber()
        {
            Console.WriteLine(GetUserInput());
        }

        static public void PrintUserNumber(string OptionalTextForUser)
        {
            Console.WriteLine(OptionalTextForUser + GetUserInput());
        }

        static void TextForUserToGetNumber()
        {
            Console.Write("Give me some number: ");
        }
    }
}
