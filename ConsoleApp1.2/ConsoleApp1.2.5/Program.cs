using System;
using System.Collections.Generic;

namespace App1
{
    class Program
    {
        static Dictionary<string, int> AvgTemperature(Dictionary<string, int[]> temps)
        {
            Dictionary<string, int> averageTemperature = new Dictionary<string, int>();
            
            foreach (var month in temps)
            {
                int sum = 0;
                for (int i = 0; i < month.Value.Length; i++)
                {
                    sum += month.Value[i];
                }
                int avg = sum / month.Value.Length;
                averageTemperature.Add(month.Key, avg);
            }
            return averageTemperature;
        }

        static void Main(string[] args)
        {
            var temps = new Dictionary<string, int[]>()
            {
                ["January"] = new int[30],
                ["February"] = new int[30],
                ["March"] = new int[30],
                ["April"] = new int[30],
                ["May"] = new int[30],
                ["June"] = new int[30],
                ["July"] = new int[30],
                ["August"] = new int[30],
                ["September"] = new int[30],
                ["October"] = new int[30],
                ["November"] = new int[30],
                ["December"] = new int[30],
            };

            Random r = new Random();
            int min = -35, max = 0, numMonth = 0;
            
            foreach (var month in temps)
            {
                for (int i = 0; i < month.Value.Length; i++)
                {
                    month.Value[i] = r.Next(min, max);
                }
                if (numMonth < 6)
                {
                    min += 6;
                    max += 7;
                }
                if (numMonth > 6)
                {
                    min -= 12;
                    max -= 11;
                }
                numMonth++;
            }

            var values = AvgTemperature(temps);
            foreach (var v in values)
            {
                Console.Write($"{v.Key}: ");
                Console.WriteLine(v.Value);
            }
        }
    }
}
