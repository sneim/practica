using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void Main()
        {
            string path = @"D:\c#\ConsoleApplication1\ConsoleApplication1\bin\Debug\Net.07\input.txt"; // полный путь к файлу
            string[] input = File.ReadAllLines(path);
            numbersInput = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbersInput[i] = int.Parse(input[i]);
            }

            int maxVolume = getMaxVolume(ref numbersInput);

            Console.WriteLine($"Максимальный возможный объем: {maxVolume}");
        }
    }
}