using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] array = new int[10];
            Random r = new Random();
     
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-100,100);
            }
     
            foreach (var i in array)
            {
                Console.Write(i + "; ");
            }
     
            int min = array[0], minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
            }
            Console.WriteLine("\n" + minIndex);
        }
    }
}