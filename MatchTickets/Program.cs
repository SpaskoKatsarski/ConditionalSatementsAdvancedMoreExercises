using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double totalSpent = 0;

            if (category == "VIP")
            {
                totalSpent = 499.99 * people;
            }
            else
            {
                totalSpent = 249.99 * people;
            }
            if (people >= 1 && people <= 4)
            {
                totalSpent += 0.75 * budget;
            }
            else if (people <= 9)
            {
                totalSpent += 0.60 * budget;
            }
            else if (people <= 24)
            {
                totalSpent += 0.50 * budget;
            }
            else if (people <= 49)
            {
                totalSpent += 0.40 * budget;
            }
            else
            {
                totalSpent += 0.25 * budget;
            }

            double difference = Math.Abs(budget - totalSpent);

            if (budget >= totalSpent)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
