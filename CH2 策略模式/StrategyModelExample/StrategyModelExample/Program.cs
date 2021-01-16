using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryModelSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cashModel = new string[] { "正常收費", "滿300送100", "打8折" };

            //工廠模式生成計價類別物件
            CashSuper csuper = CashFactory.createCashAccept(getCashModel(cashModel));

            //取得商品價格、數量資訊
            double price = getProductPrice();
            int num = getProductNumber();

            //使用多型計算應收金額
            double totalPrice = csuper.acceptCash(price * num);
            printCashInfo(price, num, totalPrice);
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

        static double getProductPrice()
        {
            Console.WriteLine("輸入商品單價:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static int getProductNumber()
        {
            Console.WriteLine("輸入商品件數:");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void printCashInfo(double price, int num, double totalPrice)
        {
            Console.WriteLine($"單價: {price}\n數量: {num}\n總額: {totalPrice}");
            Console.ReadLine();
        }
    }
}
