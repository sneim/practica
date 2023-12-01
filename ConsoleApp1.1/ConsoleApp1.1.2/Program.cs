using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] array = new int[10000];
            Console.WriteLine("Введите число: ");
            int input = 0;
            int count = 0;
     
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input != 0)
                {
                    array[count] = input;
                    count++;
                }
            } while (input != 0);
     
            int sum = 0;
            int product = 1;
     
            for (int i = 0; i < count; i++)
            {
                sum += array[i];
                product *= array[i];
            }
     
            double average = (double)sum / count;
     
            Console.WriteLine("Сумма всех элементов: " + sum);
            Console.WriteLine("Произведение всех элементов: " + product);
            Console.WriteLine("Средннее всех элементов: " + average);
        }
    }
}