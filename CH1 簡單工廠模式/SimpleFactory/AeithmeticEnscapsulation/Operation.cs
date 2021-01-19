using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeithmeticEnscapsulation
{
    class Operation
    {
        public static double GetResult(double numA, double numB, string operation)
        {
            double result = 0d;
            switch (operation)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
            }
            return result;
        }
    }
}
