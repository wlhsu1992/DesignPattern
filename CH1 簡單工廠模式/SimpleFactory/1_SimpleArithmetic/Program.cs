using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SimpleArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = getNumber();
            string operation = getOperation();
            double numB = getNumber();

            double result = 0.0d;
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

            printResult(numA, operation, numB, result);
        }

        static double getNumber()
        {
            Console.WriteLine("輸入一個數字:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static string getOperation()
        {
            Console.WriteLine("輸入運算符號: + - * /");
            return Console.ReadLine();
        }

        static void printResult(double num1, string op, double num2, double result)
        {
            Console.WriteLine($"{num1} {op} {num2} = {result}");
            Console.Read();
        } 
    }
}
