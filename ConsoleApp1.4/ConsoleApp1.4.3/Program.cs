using System;

namespace App1
{
    class Program
    {
        public static void Main()
        {
            string[] path = File.ReadAllLines(@"numsTask3.txt");
            string[] nums = path[0].Split(',');
            
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (string number in nums)
            {
                int num = int.Parse(number);

                if (num == 0)
                {
                    break;
                }

                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"Отношение минимального к максимальному числу {(float)min / max}");

        }
    }
}
