using System;
using System.IO;

namespace App3
{
    class Program
    {
        public static void Main()
        {
            string[] input =
                File.ReadAllLines(@"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.3\ConsoleApp1.3.3\bin\Debug\net7.0\vladick movemaiker.txt");

            int[] numbersInput;

            string[] b = input[0].Split(",");

            numbersInput = new int[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                numbersInput[i] = int.Parse(b[i]);
            }

            foreach (var a in numbersInput)
            {
                Console.WriteLine(a);
            }

        }
    }
}