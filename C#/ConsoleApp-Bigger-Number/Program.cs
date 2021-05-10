using System;

namespace ConsoleApp_Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greater integer is ");
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write(b);
            }
        }
    }
}
