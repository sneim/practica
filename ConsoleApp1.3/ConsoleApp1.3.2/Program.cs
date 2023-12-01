using System;
using System.IO;

namespace App3

{
    class Program2    
    {
        public static void Main()        
        {
            string input = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.3\ConsoleApp1.3.2\bin\Debug\net7.0\nums.txt";            
            
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