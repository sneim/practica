using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args) 
        {
            //..............................................................1
            /*
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
     
     //..............................................................2
     
             int[] array = new int[10000];
             Console.WriteLine("Введите число: ");
             int input = 0;
             int count = 0;
     
             do
             {
                 input = Convert.ToInt32(Console.ReadLine());
                 if (input != 0)
             {
                 array[count] = input;
                 count++;
             }
             } while (input != 0);
     
             int sum = 0;
             int product = 1;
     
             for (int i = 0; i < count; i++)
             {
                 sum += array[i];
                 product *= array[i];
             }
     
             double average = (double)sum / count;
     
             Console.WriteLine("Сумма всех элементов: " + sum);
             Console.WriteLine("Произведение всех элементов: " + product);
             Console.WriteLine("Средннее всех элементов: " + average);
             */
//......................................................................3

            /*
            string[] array = new string[10000];
            Console.WriteLine("Введите число: ");
            string input = " ";
            int count = 0;

            do
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                array[count] = input;
                count++;
                
            } while (true);

            if (array.Length > 0)
            {
                string shortest = array[0];
                string longtest = array[0];

                foreach (string element in array)
                {
                    if (element == null)
                    {
                        break;
                    }
                    if(element.Length < shortest.Length)
                        shortest = element;
                    
                    if (element.Length > longtest.Length)
                        longtest = element;
                    }

                Console.WriteLine("Самый короткий элемент: " + shortest);
                Console.WriteLine("Самый длинный элемент: " + longtest);
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
            */
//.........................................................................4
            /*
            Console.Write("Введите начало диапазона: ");
            int start = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите конец диапазона: ");
            int end = Convert.ToInt32(Console.ReadLine());
    
            int[] numbers = randomArray(start, end);
    
            Console.WriteLine("Сгенерированные числа:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    
        static int[] randomArray(int start, int end)
        {
            Random r = new Random();
            int size = 10; 
            int[] array = new int[size];
    
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(start, end + 1); 
            }
    
            return array;
        }
           */
//........................................................................5
            /*
            string input = Console.ReadLine();
            int wordAmount = 1; 
            foreach (var c in input)
            {
                if (c == ' ') 
                {
                    wordAmount++; 
                }
            }
    
            string result = "Start " + input + " End"; 
    
            Console.WriteLine($"Количество слов: {wordAmount}");
            Console.WriteLine($"Результирующая строка: {result}");
            */
        }
    }
}


