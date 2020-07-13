using System;

    class converting
    {
        static void Main(string[] args)
        {
        int fahrenheit;
        int centigrade;
        Console.WriteLine("centigrade:");
        centigrade=Convert.ToInt32(Console.ReadLine());
        fahrenheit = (centigrade * 9) / 5 + 32;
        Console.WriteLine("fahrenheit:" + fahrenheit);
        Console.ReadLine();
    }
    }
