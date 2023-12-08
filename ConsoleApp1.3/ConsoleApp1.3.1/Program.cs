using System;
using System.IO;

namespace App3
{
    class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines(@"input.txt");
            
            string[] chosenNumbers = input[0].Split(" ");           
            int str = int.Parse(input[1]);
            List<string> result = new List<string>();
            
            for (int i = 0; i < str; i++)
            { 
                string[] ticketNum = input[i + 2].Split(' ');
                int count = 0;
                
                foreach (string num1 in ticketNum)
                {
                    foreach (string num2 in chosenNumbers)
                    {
                        if (num1 == num2)
                        {
                            count++;
                            break;
                        }
                    }
                }
                if (count >= 3)
                {
                    result.Add("Lucky");
                }
                else
                {
                    result.Add(("Unlucky"));
                    
                }
            }
            File.WriteAllLines(@"output.txt", result.ToArray());

        }
    }
}
