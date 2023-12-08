using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"numsTask1.txt";
            StreamReader readTask5 = new StreamReader(path);
            string[] words = readTask5.ReadLine().Split(' ');
            
            Console.Write("Нечетные слова: ");
            foreach (string word in words)
            { 
                
                if (word.Length % 2 != 0) 
                { 
                    Console.Write(word + " ");
                }
            }
            readTask5.Close(); 
        }
    }
}

