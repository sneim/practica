using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите колчиство строк");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите колчиство столбцов");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m];
        int[,] newMatrix = new int[n, m + 1];
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"введите элементы {i+1}-й строки: ");
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                newMatrix[i, m] = 0;
            }
            else
            {
                newMatrix[i, m] = 1;
            }
            
        }
        Console.WriteLine();
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}