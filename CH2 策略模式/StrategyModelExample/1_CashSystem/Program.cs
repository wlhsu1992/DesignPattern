using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CashSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化結帳商品單價及數量
            Product product = new Product(1000, 1);

            //計算商品結帳總額
            double discount = getDiscount();
            double totalPrice = product.Price * product.Num * discount;

            //印出結帳資訊
            printCashInfo(product.Price, product.Num, totalPrice);
        }

        /// <summary>
        /// 取得商品折數
        /// </summary>
        static double getDiscount()
        {
            string[] cashModel = new string[] { "正常收費", "打八折", "打七折", "打五折" };
            Console.WriteLine("請選擇計價模式");
            for (int i = 0; i < cashModel.Length; i++)
                Console.WriteLine($"{i + 1}. {cashModel[i]}");
            int selectModelIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            switch (selectModelIndex) 
            {
                case 0:
                    return 1.0;
                case 1:
                    return 0.8;
                case 2:
                    return 0.7;
                case 3:
                    return 0.5;
                default:
                    throw new Exception("輸入錯誤");
            }
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
