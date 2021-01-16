using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cashModel = new string[] { "正常收費", "滿300送100", "打8折" };

            Console.WriteLine("請選擇計價模式");
            for (int i = 0; i < cashModel.Length; i++)
                Console.WriteLine($"{i+1}. {cashModel[i]}");
            int selectModelIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"選擇計價模式: {cashModel[selectModelIndex]}");
            Console.WriteLine();
            //工廠模式生成計價類別物件
            CashSuper csuper = CashFactory.createCashAccept(cashModel[selectModelIndex]);

            Console.WriteLine("輸入商品單價:");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入商品件數:");
            int num = Convert.ToInt32(Console.ReadLine());

            //多型計算應收金額
            double totalPrice = csuper.acceptCash(price * num);
            Console.WriteLine($"單價: {price}\n數量: {num}\n總額: {totalPrice}");
            Console.ReadLine();
        }
    }
}
