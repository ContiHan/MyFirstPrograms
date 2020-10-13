using System;

namespace MyFirstPrograms
{
    class Csharp_practise01
    {
        static int GetUserIntInput(string descriptionForUser)
        {
            int intNumber;
            do
            {
                TextForUserToInput(descriptionForUser);
            } while (int.TryParse(Console.ReadLine(), out intNumber) == false);
            return intNumber;
        }

        static double GetUserDoubleInput(string descriptionForUser)
        {
            double doubleNumber;
            do
            {
                TextForUserToInput(descriptionForUser);
            } while (double.TryParse(Console.ReadLine(), out doubleNumber) == false);
            return doubleNumber;
        }

        static void TextForUserToInput(string inputDescription)
        {
            Console.Write($"Give me {inputDescription}: ");
        }

        static int GetSquare(int numberToSquare)
        {
            return numberToSquare * numberToSquare;
        }

        public static void PrintSquareResult()
        {
            Console.WriteLine($"Square is: {GetSquare(GetUserIntInput("int number"))}");
        }

        static double GetCircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double GetCircleRadius()
        {
            return GetUserDoubleInput("circle radius");
        }

        public static void PrintCircleResult()
        {
            double radius = GetCircleRadius();
            Console.WriteLine($"Circle circumference is {GetCircleCircumference(radius):N2} and circle area is {GetCircleArea(radius):N2}");
        }
    }
}
