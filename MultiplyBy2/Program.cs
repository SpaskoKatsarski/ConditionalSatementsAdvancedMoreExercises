using System;

namespace MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            
            while (true)
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }               
                Console.WriteLine($"Result: {(num * 2):f2}");
                num = double.Parse(Console.ReadLine());
            }
        }
    }
}
