using System;
using Calculadora.Dependencies;
using Calculadora01.Entities;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator (0, 0, 0);

            string Operation = "t";

            Console.WriteLine("Hello! Welcome to the Calculator.");
            Console.WriteLine("");

            string AppFlow = "a";

            do
            {
                Console.WriteLine("");

                Console.WriteLine(Calc.MainValue);

                //first flow or after a reset;
                if (AppFlow == "a")
                {
                    Console.Write("Type the first number: ");
                    Calc.N1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    Console.Write("Type the second number: ");
                    Calc.N2 = double.Parse(Console.ReadLine());

                    View.ChooseOperation();
                    Operation = Console.ReadLine();

                    Calc.MainValue = Calc.Op(Operation);
                }

                //second flow, to keep the first number and acumulate it;
                if (AppFlow == "b")
                {
                    Console.Write("Type the second number: ");
                    Calc.N2 = double.Parse(Console.ReadLine());

                    View.ChooseOperation();
                    Operation = Console.ReadLine();

                    Calc.MainValue = Calc.Sop(Operation);
                }

                Console.WriteLine($"Total: {Math.Round(Calc.MainValue, 2)}");

                Console.WriteLine("");

                View.Options();
                AppFlow = Console.ReadLine();

                if (AppFlow == "r") //reset
                {
                    Calc.ResetMain();
                    AppFlow = "a";
                }
                else if (AppFlow == "c")
                {
                    AppFlow = "b";
                }
                else
                {
                    AppFlow = "n";
                }

            } while (AppFlow != "n");
        }
    }
}
