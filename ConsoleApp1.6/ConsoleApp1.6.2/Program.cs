using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"numsTask2.txt";
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
