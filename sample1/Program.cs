using System;


namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int temp;
    
            Console.Write("enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("first number is:" + number1);
            Console.Write("second number is:" + number2);
            Console.ReadLine();
        }
    }
}
