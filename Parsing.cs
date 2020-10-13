using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPrograms
{
    class Parsing
    {
        static public double GetUsetInput()
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
            Console.WriteLine(GetUsetInput());
        }

        static public void PrintUserNumber(string OptionalTextForUser)
        {
            Console.WriteLine(OptionalTextForUser + GetUsetInput());
        }

        static public void TextForUserToGetNumber()
        {
            Console.Write("Give me some number: ");
        }
    }
}
