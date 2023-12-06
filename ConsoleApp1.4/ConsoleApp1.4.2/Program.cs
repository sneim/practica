
using System.Globalization;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.4\ConsoleApp1.4.2\bin\Debug\net7.0\numsTask2.txt";
        string[] numbers = File.ReadAllText(path).Split(';');

        float sum = 0;

        foreach (string number in numbers)
        {
            float num = float.Parse(number, CultureInfo.InvariantCulture);

            if (num == 0)
            {
                break; // Выход из цикла, если встретилось число 0
            }

            if (num > 0)
            {
                sum += num;
            }
        }

        Console.WriteLine("Сумма положительных чисел: " + sum);
    }
}