using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01.Entities
{
    internal class View
    {
        public static void TypeFirst ()
        {
            Console.Write("Type a number: ");
        }

        public static void TypeSecond ()
        {
            Console.Write("Type the second number: ");
        }

        public static void ChooseOperation ()
        {
            Console.WriteLine("Choose the operation: ");
            Console.WriteLine(" +");
            Console.WriteLine(" -");
            Console.WriteLine(" *");
            Console.WriteLine(" /");
        }

        public static void Options ()
        {
            Console.WriteLine("Type 'n' to quit.");
            Console.WriteLine("Type 'r' to reset the values.");
            Console.WriteLine("Type 'c' to keep using.");
        }
    }
}
