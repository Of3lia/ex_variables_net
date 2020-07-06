using System;

namespace Exercici_Variables_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Ofelia";
            string cognom1 = "Cocucci";
            string cognom2 = "Furlan";

            Console.WriteLine($"{cognom1} {cognom2} {nom}");

            int dia = 6;
            int mes = 7;
            int any = 2020;

            Console.WriteLine($"{dia}/{mes}/{any}");
        }
    }
}
