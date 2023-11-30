using System;
using System.Globalization;
using System.Xml.Schema;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
//.......................................................................1
            /*
            int[] array = new int[100];
            int currentNumber = 300;
            for (int i = 0; i < 100; i++)
            {
                array[i] = currentNumber;
                currentNumber -= 3;
            }
    
            for (int i = 0; i < 100; i++)
            {
                Console.Write(array[i] + " ");
            }
            */
//........................................................................2        
            /*
            int[] array = new int[10];
        
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1 + i * 4;
                Console.WriteLine(array[i]);
            }
            */
//.........................................................................3
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                matrix[0, i] = 1;
                matrix[i, 0] = 1;
            }
            
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */
//..........................................................................4
            /*
            int[,] temperature = new int[12, 30];
            Random r = new Random();
            int min = -35;
            int max = 0;
                

            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temperature[month, day] = r.Next(min, max);
                }

                if (month < 6)
                {
                    min += 6;
                    max += 7;
                }

                if (month > 6)
                {
                    min -= 12;
                    max -= 11;
                }
            }

            static int[] averageTemperature(int[,] temperature)
            {
                int[] avgTemps = new int[12];
                int sum = 0;

                for (int month = 0; month < 12; month++)
                {
                    sum = 0;
                    for (int day = 0; day < 30; day++)
                    {
                        sum += temperature[month, day];
                    }

                    avgTemps[month] = sum / 30;
                }

                return avgTemps;
            }

            int[] avgTemps = averageTemperature(temperature);
            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine($"{avgTemps[month]}°C");
            }
            Array.Sort(avgTemps); 
            */
//..........................................................................5
            
            var temperature = new Dictionary<int, string>()
            {
                /*
                {"January", 30};
                {"February", 30};
                {"March", 30};
                {"April", 30};
                {"May", 30};
                {"June", 30};
                {"July", 30};
                {"August", 30};
                {"September", 30};
                {"October", 30};
                {"November", 30};
                {"December", 30};
                */
            };
            /*
            Random r = new Random();
            int min = -35;
            int max = 0;
            string[] month = new string["January", ]

            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temperature[month, day] = r.Next(min, max);
                }
            }
            var monthlyTemps = new Dictionary<string, int[]>();

            int[] averageTemps = averageTemperature(temperature);
            
            foreach(var day in month)
            {
                Console.WriteLine($"Месяца: {day.Key}  value: {day.Value}");
            }
             */
            
        }
    }
}