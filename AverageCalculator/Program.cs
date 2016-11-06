using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sąrašo ilgį:");
            string ArrayLengthString = Console.ReadLine();
            int ArrayLength;
            if (!int.TryParse(ArrayLengthString, out ArrayLength))
            {
                Console.WriteLine("Neteisingai ivesti parametrai");
                return;
            }
            if (ArrayLength <= 0)
            {
                Console.WriteLine("Saraso ilgis turi buti didesnis uz 0");
                return;
            }
            Console.WriteLine("Iveskite " + ArrayLength + " skaicius");
            decimal sum = 0;
            for (int i = 0; i < ArrayLength; i++)
            {
                start:
                Decimal Number;
                string NumberString = Console.ReadLine();
                if (!decimal.TryParse(NumberString, out Number))
                {
                    Console.WriteLine("Iveskite skaiciu");
                    goto start;
                }
                sum += Number;
            }
            Console.WriteLine("Atsakymas: " + sum / ArrayLength);
            Console.ReadLine();
        }
    }
}

