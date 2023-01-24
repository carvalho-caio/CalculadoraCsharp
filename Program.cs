using System;
using Calculadora.Dependencies;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Calculator.");
            Console.WriteLine("");

            string Exit = "n";

            do
            {
                Console.Write("Type the first number: ");
                double A = Double.Parse(Console.ReadLine());

                Console.Write("Type the second number: ");
                double B = Double.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.Write("Which opereration do you want to execute? ");
                Console.Write("\nPlus (+)\nMinus(-)\nMultiplication(*)\nDivision(/)\n");
                string Operation = Console.ReadLine();

                if (Operation == "+")
                {
                    Console.WriteLine(Calculator.Plus(A, B));
                }
                else if (Operation == "-")
                {
                    Console.WriteLine(Calculator.Minus(A, B));
                }
                else if (Operation == "*")
                {
                    Console.WriteLine(Calculator.Multi(A, B));
                }
                else if (Operation == "/")
                {
                    Console.WriteLine(Calculator.Div(A, B));
                }
                else
                {
                    Console.WriteLine("Invalid Syntax");
                    break;
                }

                Console.WriteLine("Do you want to keep using? (y/n)");
                Exit = Console.ReadLine();

            } while (Exit != "n");
        }
    }
}