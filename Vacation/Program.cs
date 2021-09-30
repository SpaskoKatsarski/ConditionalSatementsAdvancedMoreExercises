using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "0";
            string placeToSleep = "0";
            double total = 0;

            if (budget <= 1000)
            {
                placeToSleep = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    total = 0.65 * budget;
                }
                else
                {
                    location = "Morocco";
                    total = 0.45 * budget;
                }
            }
            else if (budget > 100 && budget <= 3000)
            {
                placeToSleep = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    total = 0.80 * budget;
                }
                else
                {
                    location = "Morocco";
                    total = 0.60 * budget;
                }
            }
            else
            {
                placeToSleep = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    total = 0.90 * budget;
                }
                else
                {
                    location = "Morocco";
                    total = 0.90 * budget;
                }
            }
            Console.WriteLine($"{location} - {placeToSleep} - {total:f2}");
        }
    }
}
