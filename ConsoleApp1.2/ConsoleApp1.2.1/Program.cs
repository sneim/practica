using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int currentNumber = 300;
            for (int i = 0; i < 100; i++)
            {
                array[i] = currentNumber;
                currentNumber -= 3;
            }
    
            for (int i = 0; i < 100; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}