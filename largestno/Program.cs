using System;
    class Program
    {
        static void Main(string[] args)
        {
			int number1;
			int number2;
			int number3;

			Console.Write("enter 1st number: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter 2nd number: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter 3rd number: ");
			number3 = Convert.ToInt32(Console.ReadLine());

			if (number1 > number2)
			{
				if (number1 > number3)
				{
					Console.WriteLine("first number is greatest");
					Console.ReadLine();
				}
				else
				{
					Console.Write("third number is greatest");
					Console.ReadLine();
				}
			}
			else if (number2 > number3)
				Console.Write("second number is greatest");

			else
				Console.Write("third number is greatest");
			Console.ReadLine();
		}
    }
