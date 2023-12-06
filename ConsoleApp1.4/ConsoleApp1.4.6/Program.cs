using System.Globalization;

namespace App1
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
                Console.WriteLine("Точка с координатами (" + a + "; " + b + ") принадлежит заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка с координатами (" + a + "; " + b + ") не принадлежит заштрихованной области.");
            }
        }
    }
}