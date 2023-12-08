using System;
using System.IO;

namespace App1

{
    class Program2    
    {
        public static void Main()        
        {
            string input = @"nums.txt";            
            
            string[] pathInput = File.ReadAllLines(input);
            
            File.WriteAllText(input, string.Empty);
            string write = String.Empty;
            
            foreach (string el in pathInput[0].Split(" "))            
            {
                if (el != "" && int.Parse(el)% 2 != 0)                
                {
                    write += el + " ";                    
                }                
            }            
            File.WriteAllText(input, write);
        }    
    }
}
