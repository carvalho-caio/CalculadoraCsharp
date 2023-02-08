using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Dependencies
{
    internal class Calculator
    {
        //main variable that will persist the value in the program;
        public double MainValue { get; set; }

        //value variables to do the math and be reset;
        public double N1 { get; set; }
        public double N2 { get; set; }


        //constructors
        public Calculator()
        {

        }

        public Calculator(double mainValue, double n1, double n2)
        {
            MainValue = mainValue;
            N1 = n1;
            N2 = n2;
        }

        //methods
        public double Op(string op)
        {
            if(op == "+")
            {
                return N1 + N2;
            }
            else if (op == "-")
            {
                return N1 - N2;
            }
            else if (op == "*")
            {
                return N1 * N2;
            }
            else if (op == "/")
            {
                return N1 / N2;
            }
            else
            {
                Console.WriteLine("Invalid parameter!");
                return 0;
            }
        }

        public double Sop (string op)
        {
            if(op == "+")
            {
                return MainValue += N2;
            }
            else if (op == "-")
            {
                return MainValue -= N2;
            }
            else if (op == "*")
            {
                return MainValue *= N2;
            }
            else if (op == "/")
            {
                return MainValue /= N2;
            }
            else
            {
                Console.WriteLine("Invalid parameter!");
                return 0;
            }
        }

        public void ResetMain ()
        {
            MainValue = 0;
        }

    }
}
