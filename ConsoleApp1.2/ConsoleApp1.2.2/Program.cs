using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
        
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1 + i * 4;
                Console.WriteLine(array[i]);
            }
        }
    }
}