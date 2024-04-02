using System;


namespace Laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();

            number.RandomValue();
            Console.WriteLine(number.ToString());

            Console.WriteLine("\nWe place signs");

            Sign sign = new Sign();

            sign.RandomValue();
            sign.RandomSign();
            Console.WriteLine(sign.ToString());

            Console.WriteLine("\nMake fractions with these numbers");

            SimpleFraction fraction = new SimpleFraction();

            fraction.RandomValue();
            fraction.RandomSign();
            fraction.CreateFraction();
            Console.WriteLine(fraction.ToString());
        }
    }
}
