using System;

namespace App1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()); 

            int product = 1;
            for (int i = 3; i <= n; i += 3) 
            {
                product *= i; 
            }

            Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающих " + n + " равно " + product);
        }
    }
}