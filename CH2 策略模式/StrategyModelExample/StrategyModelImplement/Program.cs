using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            //輸入處理: Product.Price:商品單價; Product.Num: 商品數量; cashModel: 折扣模式
            Product product = new Product(1000, 2);
            string[] cashModelArray = new string[] { "正常收費", "滿300送100", "打8折" };
            string cashModel = getCashModel(cashModelArray);

            //策略模式計算商品價格
            CashContext csuper = new CashContext(cashModel);
            double totalPrice = csuper.GetResult(product.Price * product.Num);

            //輸出處理
            printCashInfo(product.Price, product.Num, totalPrice);
        }

        static string getCashModel(string[] cashModel)
        {
            Console.WriteLine("請選擇計價模式");
            for (int i = 0; i < cashModel.Length; i++)
                Console.WriteLine($"{i + 1}. {cashModel[i]}");
            int selectModelIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            string selectCashModel = cashModel[selectModelIndex];
            Console.WriteLine($"選擇計價模式: {selectCashModel}");
            return selectCashModel;
        }

        static void printCashInfo(double price, int num, double totalPrice)
        {
            Console.WriteLine($"單價: {price}\n數量: {num}\n總額: {totalPrice}");
            Console.ReadLine();
        }
    }
}
