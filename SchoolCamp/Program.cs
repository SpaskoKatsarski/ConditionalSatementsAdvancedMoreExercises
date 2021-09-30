using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double total = 0;
            string sport = "0";

            if (season == "Winter")
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    total = 9.60 * nights * students;
                }
                else
                {
                    total = 10 * nights * students;
                }
            }
            else if (season == "Spring")
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    total = 7.20 * nights * students;
                }
                else
                {
                    total = 9.50 * nights * students;
                }
            }
            else
            {
                if (typeOfGroup == "boys" || typeOfGroup == "girls")
                {
                    total = 15 * nights * students;
                }
                else
                {
                    total = 20 * nights * students;
                }
            }
            if (students >= 50)
            {
                total *= 0.50;
            }
            else if (students >= 20)
            {
                total *= 0.85;
            }
            else if (students >= 10)
            {
                total *= 0.95;
            }
            if (season == "Winter")
            {
                if (typeOfGroup == "boys")
                {
                    sport = "Judo";
                }
                else if (typeOfGroup == "girls")
                {
                    sport = "Gymnastics";
                }
                else
                {
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (typeOfGroup == "boys")
                {
                    sport = "Tennis";
                }
                else if (typeOfGroup == "girls")
                {
                    sport = "Athletics";
                }
                else
                {
                    sport = "Cycling";
                }
            }
            else
            {
                if (typeOfGroup == "boys")
                {
                    sport = "Football";
                }
                else if (typeOfGroup == "girls")
                {
                    sport = "Volleyball";
                }
                else
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {total:f2} lv.");
        }
    }
}
