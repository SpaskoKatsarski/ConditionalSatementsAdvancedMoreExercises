using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            // 1 season = 4 months

            double total = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    total = kmPerMonth * 0.75 * 4;
                }
                else if (season == "Summer")
                {
                    total = kmPerMonth * 0.90 * 4;
                }
                else
                {
                    total = kmPerMonth * 1.05 * 4;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    total = kmPerMonth * 0.95 * 4;
                }
                else if (season == "Summer")
                {
                    total = kmPerMonth * 1.10 * 4;
                }
                else
                {
                    total = kmPerMonth * 1.25 * 4;
                }
            }
            else
            {
                total = kmPerMonth * 1.45 * 4;
            }
            double finalPrice = 0.90 * total;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
