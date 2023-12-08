using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string path = @"input.txt";
        using (StreamReader stream = new StreamReader(path))
        {
            string s = stream.ReadLine();
            string[] array = s.Split(' ');
            int resultVolum = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int coup = Convert.ToInt32(array[i]);
                int min = coup;
                int volum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    int coupSec = Convert.ToInt32(array[j]);
                    if (coup < coupSec)
                    {
                        min = coup;
                    }
                    else
                    {
                        min = coupSec;
                    }
                    volum = min * (i - j);
                    if (volum > resultVolum)
                    {
                        resultVolum = volum;
                    }
                }
            }

            Console.WriteLine($"Максимальный возможный объем: {resultVolum}");
        }
    }
}
