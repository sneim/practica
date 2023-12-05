using System;
using System.IO;
using System.Globalization;


namespace App3
{
    class Program
    {
        public static void Main()
        {
            string path =
                @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.4\ConsoleApp1.4.3\bin\Debug\net7.0\numsTask3.txt";
            string[] stringNumbers = File.ReadAllText(path).Split(',');

            int minNumber = int.Parse(stringNumbers[0]);
            int maxNumber = int.Parse(stringNumbers[0]);

            if (maxNumber != 0) 
            {
                foreach (string stringNumber in stringNumbers)
                {
                    int num = int.Parse(stringNumber, CultureInfo.InvariantCulture);

                    if (num == 0)
                    {
                        break;
                    }

                    if (minNumber > num)
                    {
                        minNumber = num;
                    }

                    if (maxNumber < num)
                    {
                        maxNumber = num;
                    }
                }

                Console.WriteLine($"Отношение минимального к максимальному числу {(float)minNumber / maxNumber}");
            }
            else
            {
                Console.WriteLine("Первое число это 0");
            }
        }
    }
}