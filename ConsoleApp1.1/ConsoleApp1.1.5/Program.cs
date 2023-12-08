using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите предложение: ");
            string input = Console.ReadLine();
            int wordAmount = 1; 
            foreach (var c in input)
            {
                if (c == ' ') 
                {
                    wordAmount++; 
                }
            }
    
            string result = "Start " + input + " End"; 
    
            Console.WriteLine($"Количество слов: {wordAmount}");
            Console.WriteLine($"Результирующая строка: {result}");
        }
    }
}
