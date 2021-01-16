using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入數字A");
                double numberA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入運算符號(+、-、*、/):");
                string operate = Console.ReadLine();
                Console.WriteLine("請輸入數字B");
                double numberB = Convert.ToDouble(Console.ReadLine());
                BaseOperation oper;
                oper = OperationFactory.createOperate("+");
                oper.NumberA = numberA;
                oper.NumberB = numberB;
                double result = oper.GetResult();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"輸入有誤 {ex}");
            }
            Console.ReadLine();
        }
    }
}
