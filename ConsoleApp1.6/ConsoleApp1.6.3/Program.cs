using System;

class Program 
{
    static void Main(string[] args) 
    { 
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0 && num % 10 == 0)
        {
            Console.WriteLine("Число четное и кратное 10-ти.");
        }
        else if(num % 2 == 0 && num % 10 != 0)
        {
            Console.WriteLine("Число четное, но не является кратным 10-ти.");
        }
        else
        {
            Console.WriteLine("Число нечетное и не является кратным 10-ти.");
        }
    } 
}
