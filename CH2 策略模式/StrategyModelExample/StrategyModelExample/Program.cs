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
            //資料輸入
            Product product = new Product(1000, 1);
            string[] cashModel = new string[] { "正常收費", "滿300送100", "打八折" };
            string selectCashModel = getCashModel(cashModel);

            //計算商品結帳總額
            CashSuper cs = CashFactory.createCashAccept(selectCashModel);
            double finalPrice = cs.acceptCash(product.Price * product.Num);

            //資料輸出
            printCashInfo(product.Price, product.Num, finalPrice);
        }

        /// <summary>
        /// 取得計價方案
        /// </summary>
        static string getCashModel(string[] cashModel)
        {
            Console.WriteLine("選擇折扣方案");
            for (int i = 0; i < cashModel.Length; i++)
                Console.WriteLine($"{i+1}. {cashModel[i]}");
            return cashModel[Convert.ToInt32(Console.ReadLine()) - 1];
        }

        /// <summary>
        /// 印出結帳資訊
        /// </summary>
        static void printCashInfo(double price, int num, double totalPrice)
        {
            Console.WriteLine($"單價: {price}\n數量: {num}\n總額: {totalPrice}");
            Console.ReadLine();
        }
    }
}
