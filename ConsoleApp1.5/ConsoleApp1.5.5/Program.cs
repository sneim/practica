using System;
using System.IO;

namespace App1
{
    class Program
    {
        private static int getIndexMaxElement(int[] numbers)
        {
            int maxIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[maxIndex] < numbers[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private static int FindMinimumIndex(int[] numbers)
        {
            int minIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[minIndex] > numbers[i]) 
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        private static float getAverageBetween(int[] numbers, int startIndex, int endIndex)
        {
            float average = 0;
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                average += numbers[i];
            }
            return average / (endIndex - startIndex - 1);
        }

        public static void Main()
        {
            string path = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.5\ConsoleApp1.5.5\bin\Debug\net7.0\numsTask5.txt";
            StreamReader readTask5 = new StreamReader(path);
            string[] input = readTask5.ReadLine().Split(' ');

            readTask5.Close();
            
            int[] numbers = Array.ConvertAll(input, int.Parse);
            
            int maxIndexNum = getIndexMaxElement(numbers);
            
            int minIndexNum = FindMinimumIndex(numbers);
            
            float result = getAverageBetween(numbers, (minIndexNum < maxIndexNum) ? minIndexNum : maxIndexNum, (minIndexNum > maxIndexNum) ? minIndexNum : maxIndexNum);
            
            Console.WriteLine($"Среднее арифметическое элементов расположенных между минимальным и максимальным: {result}");
        }
    }
}