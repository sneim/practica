using System;

class Program
{
    static void Main()
    {
        double a, b;
        Console.WriteLine("Введите координату a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату b: ");
        b = Convert.ToDouble(Console.ReadLine());

        if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
        {
            Console.WriteLine("Точка с координатами (" + a + "; " + b + ") принадлежит заштрихованной области.");
        }
        else
        {
            Console.WriteLine("Точка с координатами (" + a + "; " + b + ") не принадлежит заштрихованной области.");
        }
    }
}