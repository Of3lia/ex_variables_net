using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ophelia";
            string surName1 = "Cocucci";
            string surName2 = "Furlan";

            string fullName = $"{name} {surName1} {surName2}";

            int day = 8;
            int month = 2;
            int year = 1995;

            string fullBirthDate = $"{day}/{month}/{year}";

            const int LEAP_YEAR = 1948;
            int birthYear = 1995;
            int i;
            bool isBirthLeapYear;
            string isLeap = "I was born on a Leap-Year";
            string isNotLeap = "I was NOT born on a Leap-Year";

            for(i = LEAP_YEAR; i < birthYear; i += 4)
            {
                Console.WriteLine($"Leap-Year: {i}");
            }

            if (i == birthYear)
            {
                isBirthLeapYear = true;
            }
            else
            {
                isBirthLeapYear = false;
            }

            Console.WriteLine($"My full name is {fullName}");
            Console.WriteLine($"My birthday is {fullBirthDate}");

            switch (isBirthLeapYear)
            {
                case true:
                    Console.WriteLine(isLeap);
                    break;
                case false:
                    Console.WriteLine(isNotLeap);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}