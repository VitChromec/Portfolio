using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Kalkulačka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("._.Welcome to calculator._.");
            Thread.Sleep(2000);
            Console.WriteLine("This program can do basic mathematical operations with integers such as multiplying, dividing and more!");
            Thread.Sleep(2000);
            Console.WriteLine("Type +, -, *, / ");
            string a = Console.ReadLine();

            if (a == "+")
            { Console.WriteLine("Enter first number");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int sec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(first + " + " + sec + " = " + (first + sec));
                Thread.Sleep(5000);
            }
            if (a == "-")
            {
                Console.WriteLine("Enter first number");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int sec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(first + " - " + sec + " = " + (first - sec));
                Thread.Sleep(5000);
            }
            if (a == "*")
            {
                Console.WriteLine("Enter first number");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int sec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(first + " * " + sec + " = " + (first * sec));
                Thread.Sleep(5000);
            }
            if (a == "/")
            {
                Console.WriteLine("Enter first number");
                float first = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                float sec = float.Parse(Console.ReadLine());
                Console.WriteLine(first + " / " + sec + " = " + (first / sec));
                Thread.Sleep(5000);
            }
        }

    }
}
