using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        double[] array = new double[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = Convert.ToDouble(inputArray[i]);
        }
        
        List<double> positiveElements = new List<double>();
        List<double> negativeElements = new List<double>();
        
        foreach (double number in array)
        {
            if (number > 0)
            {
                positiveElements.Add(number);
            }
            else if (number < 0)
            {
                negativeElements.Add(number);
            }
        }

        Console.WriteLine("\n Положительные элементы:");
        foreach (float num in positiveElements)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine("\n Отрицательные элементы:");
        foreach (float num in negativeElements)
        {
            Console.Write(num + " ");
        }
        
    }
}