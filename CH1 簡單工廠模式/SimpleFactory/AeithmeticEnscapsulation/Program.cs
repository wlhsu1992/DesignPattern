using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeithmeticEnscapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //介面輸入邏輯
            double numA = getNumber();
            string operation = getOperation();
            double numB = getNumber();

            double result = Operation.GetResult(numA, numB, operation);

            //介面輸出邏輯
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
