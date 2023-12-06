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
        
        private static int getSumElDifferin1MaxNumber(int[] numbers, int maxIndex)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[maxIndex] - numbers[i] == 1)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public static void Main()
        {
            string path = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.5\ConsoleApp1.5.4\bin\Debug\net7.0\numsTask4.txt";
            StreamReader readTask4 = new StreamReader(path);
            string[] input = readTask4.ReadLine().Split(' ');

            readTask4.Close();
            
            int[] numbers = Array.ConvertAll(input, int.Parse); 
            
            int maxIndexNum = getIndexMaxElement(numbers);
            int result = getSumElDifferin1MaxNumber(numbers, maxIndexNum);
            
            Console.WriteLine($"Сумма элементов, отличающихся от максимального на 1: {result}");
        }
    }
}