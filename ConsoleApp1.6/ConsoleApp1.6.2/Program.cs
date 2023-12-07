using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.6\ConsoleApp1.6.2\bin\Debug\net7.0\numsTask2.txt";
            StreamReader readInput = new StreamReader(path);
            string words = readInput.ReadLine();
            
            while(words != null)
            {
                Console.Write(words + " ");
                words = readInput.ReadLine();
            }

            readInput.Close();
            
        }
    }
}