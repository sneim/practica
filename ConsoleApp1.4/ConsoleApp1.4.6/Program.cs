using System;
using System.Globalization;

namespace App6
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число a (x): "); 
            float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите число b (y): ");
            float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if ((((b - 2) / 2.5) <= a && ((b - 2) / -2.5) >= a ) && (b >= -3 && b <= 2)) 
            {
                Console.WriteLine("Точка входит d область");
            }
            else
            {
                Console.WriteLine("Точка не входит в область");
            }
        }
    }
}