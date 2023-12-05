using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp4\ConsoleApp1.4.2\bin\Debug\net7.0\numsTask2.txt";
        string[] numbers = File.ReadAllText(filePath).Split(';'); 
        
        float sum = 0;
        
        foreach (string number in numbers) 
        { 
            float num = float.Parse(number, CultureInfo.InvariantCulture);
            
            if (num == 0) 
            {
                break;
            }

            if (num > 0) 
            { 
                sum += num; 
            }
        }
        Console.WriteLine("Сумма положительных чисел: " + sum);

    }
}