using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FOR_TRAIL_JUNIORS = 5.50;
            const double PRICE_FOR_TRAIL_SENIORS = 7;
            const double PRICE_FOR_CROSS_COUNTRY_JUNIORS = 8;
            const double PRICE_FOR_CROSS_COUNTRY_SENIORS = 9.50;
            const double PRICE_FOR_DOWNHILL_JUNIORS = 12.25;
            const double PRICE_FOR_DOWNHILL_SENIORS = 13.75;
            const double PRICE_FOR_ROAD_JUNIORS = 20;
            const double PRICE_FOR_ROAD_SENIORS = 21.50;

            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeTrack = Console.ReadLine();

            double allPrice = 0;

            if (typeTrack == "trail")
            {
                allPrice = juniors * PRICE_FOR_TRAIL_JUNIORS + seniors * PRICE_FOR_TRAIL_SENIORS;
            }
            else if (typeTrack == "cross-country")
            {
                if (juniors + seniors >= 50)
                {
                    allPrice = (juniors * PRICE_FOR_CROSS_COUNTRY_JUNIORS + seniors * PRICE_FOR_CROSS_COUNTRY_SENIORS) * 0.75;
                }
                else
                {
                    allPrice = juniors * PRICE_FOR_CROSS_COUNTRY_JUNIORS + seniors * PRICE_FOR_CROSS_COUNTRY_SENIORS;
                }
                
            }
            else if (typeTrack == "downhill")
            {
                allPrice = juniors * PRICE_FOR_DOWNHILL_JUNIORS + seniors * PRICE_FOR_DOWNHILL_SENIORS;
            }
            else
            {
                allPrice = juniors * PRICE_FOR_ROAD_JUNIORS + seniors * PRICE_FOR_ROAD_SENIORS;
            }
            double total = allPrice * 0.95;
            Console.WriteLine($"{total:f2}");
        }
    }
}
