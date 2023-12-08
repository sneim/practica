using System;
using System.IO;

namespace App1
{
    class Program
    {
        private static int getIndexMinElement(int[] numbers)
        {
            int minIndex = 0;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[minIndex] > numbers[i])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static int getMulNumbersAfter(int[] numbers, int minIndex)
        {
            int result = 1;
            
            for (int i = minIndex + 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            

            return result;
        }
        
        public static void Main()
        {
            string path = @"numsTask1.txt";
            StreamReader readTask1 = new StreamReader(path);
            string[] input = readTask1.ReadLine().Split(';');

            readTask1.Close();
            
            int[] numbers = Array.ConvertAll(input, int.Parse);

            int minIndex = getIndexMinElement(numbers);
            int result = getMulNumbersAfter(numbers, minIndex);

            Console.WriteLine("Произведение элементов после минимального: " + result);
        }
    }
}
