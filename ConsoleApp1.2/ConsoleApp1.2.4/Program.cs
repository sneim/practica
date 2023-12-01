using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] temperature = new int[12, 30];
            Random r = new Random();
            int min = -35, max = 0;

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
        }
    }
}