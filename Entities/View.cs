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
            Console.WriteLine("Escolha qual operação quer realizar: ");
            Console.WriteLine(" +");
            Console.WriteLine(" -");
            Console.WriteLine(" *");
            Console.WriteLine(" /");
        }

        public static void Options ()
        {
            Console.WriteLine("Digite 'n' para sair.");
            Console.WriteLine("Digite 'r' para resetar os valores.");
            Console.WriteLine("Digite 'c' para continuar utilizando.");
        }
    }
}
