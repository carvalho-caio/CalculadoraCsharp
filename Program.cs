using System;
using Calculadora.Dependencies;
using Calculadora01.Entities;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Acumulator = 0;
            string Operation = "t";
            double F = 0;
            double S = 0;

            Console.WriteLine("Hello! Welcome to the Calculator.");
            Console.WriteLine("");

            string Exit = "a";

            do
            {
                Console.WriteLine("");

                Console.WriteLine(Acumulator);

                if (Exit == "a")
                {
                    Console.Write("Digite o primeiro número: ");
                    F = double.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    Console.Write("Digite o segundo número: ");
                    S = double.Parse(Console.ReadLine());

                    View.ChooseOperation();
                    Operation = Console.ReadLine();

                    if (Operation == "+")
                    {
                        Acumulator = Calculator.Plus(F, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "-")
                    {
                        Acumulator = Calculator.Minus(F, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "*")
                    {
                        Acumulator = Calculator.Multi(F, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "/")
                    {
                        Acumulator = Calculator.Div(F, S);
                        F = 0;
                        S = 0;
                    }
                    else
                    {
                        Console.WriteLine("Parametro invalido!");
                        break;
                    }
                }

                if (Acumulator > 0 && Exit != "a")
                {
                    Console.Write("Digite o segundo número: ");
                    S = double.Parse(Console.ReadLine());

                    View.ChooseOperation();
                    Operation = Console.ReadLine();

                    if (Operation == "+")
                    {
                        Acumulator = Calculator.Plus(Acumulator, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "-")
                    {
                        Acumulator = Calculator.Minus(Acumulator, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "*")
                    {
                        Acumulator = Calculator.Multi(Acumulator, S);
                        F = 0;
                        S = 0;
                    }
                    else if (Operation == "/")
                    {
                        Acumulator = Calculator.Div(Acumulator, S);
                        F = 0;
                        S = 0;
                    }
                    else
                    {
                        Console.WriteLine("Parametro invalido!");
                        break;
                    }
                }

                Console.WriteLine($"Total: {Acumulator}");

                Console.WriteLine("");

                View.Options();
                Exit = Console.ReadLine();

                if (Exit == "r")
                {
                    Acumulator = 0;
                    Exit = "a";
                }
                else if (Exit != "n")
                {
                    Exit = "c";
                }

            } while (Exit != "n");
        }
    }
}