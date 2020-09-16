using System;

namespace OnzeTweedeRepositoryMetVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal:");

            int getal = ConsoleHelper.GetInteger();

            int som = getal + getal;

            Console.WriteLine($"De som is: {som}");
        }
    }
}
