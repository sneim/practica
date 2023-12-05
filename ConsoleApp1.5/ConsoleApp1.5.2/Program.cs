using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void sortFloatArray(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j + 1])
                    { 
                        float temp = array[i];
                        array[i] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        
        public static void Main()
        {
            string path =
                @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.5\ConsoleApp1.5.2\bin\Debug\net7.0\numsTask2.txt";
            string[] numbers = File.ReadAllText(path).Split(';');
            
            float[] nums = Array.ConvertAll(numbers, float.Parse);

            Array.Sort(nums);

            string sortNumbers = string.Join(";", nums);
            File.WriteAllText(path, sortNumbers);

            Console.WriteLine("Числа были отсортированы и записаны обратно в файл.");
        }
        
    }
}