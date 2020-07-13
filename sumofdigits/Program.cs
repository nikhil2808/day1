using System;
    class program
    {
        static void Main(string[] args)
        {
            int number,sum;
            Console.Write("enter number: ");
 number = Convert.ToInt32(Console.ReadLine());
        sum = 0;
            while (number!=0)
            {
            sum += number % 10;
            number /= 10;
            }
            Console.WriteLine("sum is " + sum);
        Console.ReadLine();
        }
    }
