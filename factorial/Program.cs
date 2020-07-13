using System;


namespace factorial
{
    class Program
    {

        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of number is:" + fact);
            Console.ReadLine();
        }
    }
}
