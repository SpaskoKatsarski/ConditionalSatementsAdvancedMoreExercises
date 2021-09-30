using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

             double PRICE_CHRYSANTHEMUMS_IN_SPRING_OR_SUMMER = 2.00 * chrysanthemum;
             double PRICE_ROSES_IN_SPRING_OR_SUMMER = 4.10 * roses;
             double PRICE_TULIPS_IN_SPRING_OR_SUMMER = 2.50 * tulips;
             double PRICE_CHRYSANTHEMUMS_IN_AUTUMN_OR_WINTER = 3.75 * chrysanthemum;
             double PRICE_ROSES_IN_AUTUMN_OR_WINTER = 4.50 * roses;
             double PRICE_TULIPS_IN_AUTUMN_OR_WINTER = 4.15 * tulips;

            if (holiday == 'Y')
            {
                PRICE_CHRYSANTHEMUMS_IN_SPRING_OR_SUMMER *= 1.15;
                PRICE_ROSES_IN_SPRING_OR_SUMMER *= 1.15;
                PRICE_TULIPS_IN_SPRING_OR_SUMMER *= 1.15;
                PRICE_CHRYSANTHEMUMS_IN_AUTUMN_OR_WINTER *= 1.15;
                PRICE_ROSES_IN_AUTUMN_OR_WINTER *= 1.15;
                PRICE_TULIPS_IN_AUTUMN_OR_WINTER *= 1.15;            
            }

            double total = 0;

            if (season == "Spring" || season == "Summer")
            {
                total = PRICE_CHRYSANTHEMUMS_IN_SPRING_OR_SUMMER + PRICE_ROSES_IN_SPRING_OR_SUMMER + PRICE_TULIPS_IN_SPRING_OR_SUMMER;
                if (tulips > 7 && season == "Spring")
                {
                    total *= 0.95;
                }           
            }
            if (season == "Winter" || season == "Autumn")
            {
                total = PRICE_CHRYSANTHEMUMS_IN_AUTUMN_OR_WINTER + PRICE_ROSES_IN_AUTUMN_OR_WINTER + PRICE_TULIPS_IN_AUTUMN_OR_WINTER;
                if (roses >= 10 && season == "Winter")
                {
                    total *= 0.90;
                }
            }
            if (chrysanthemum + roses + tulips > 20)
            {
                total *= 0.80;
            }
            double finalPrice = total + 2;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
