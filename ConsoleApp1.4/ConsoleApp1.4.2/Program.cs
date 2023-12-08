
using System.Globalization;

class Program
{
    static void Main()
    {
        string path = @"numsTask2.txt";
        string[] numbers = File.ReadAllText(path).Split(';');

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
