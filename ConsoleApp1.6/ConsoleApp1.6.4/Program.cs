using System;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        
        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                break;
            }
            
            if (num % a == 0)
            {
                sum += num;
            }
        }
        Console.WriteLine($"сумму чисел, делящихся на положительное число a нацело равна: {sum}");
    }
}