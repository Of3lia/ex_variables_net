using System;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int leapYear = 1948;

            int timeBetweenLeapYear = 4;

            int birthYear = 1995;

            Console.WriteLine(CalculateLeapYearsPassed(leapYear, birthYear, timeBetweenLeapYear));

            int CalculateLeapYearsPassed(int _leapYear, int _date, int _timeBetweenLeapYear)
            {
                int leapYearsPassed = 0;

                while (_leapYear + leapYearsPassed <= _date)
                {
                    leapYearsPassed += _timeBetweenLeapYear;
                }

                return leapYearsPassed;
            }
        }
    }
}
