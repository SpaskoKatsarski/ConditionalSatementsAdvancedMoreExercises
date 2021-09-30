using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classification = "0";
            string type = "0";
            double total = 0;

            if (budget <= 100)
            {
                classification = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    total = 0.35 * budget;
                }
                else
                {
                    type = "Jeep";
                    total = 0.65 * budget;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classification = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    total = 0.45 * budget;
                }
                else
                {
                    type = "Jeep";
                    total = 0.80 * budget;
                }
            }
            else
            {
                classification = "Luxury class";
                type = "Jeep";
                total = 0.90 * budget;
            }
            Console.WriteLine(classification);
            Console.WriteLine($"{type} - {total:f2}");
        }
    }
}
