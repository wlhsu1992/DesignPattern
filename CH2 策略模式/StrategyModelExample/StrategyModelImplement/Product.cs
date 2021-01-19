using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
{
    public class Product
    {
        /// <summary>
        /// 商品單價
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// 商品數量
        /// </summary>
        public int Num { get; }

        /// <summary>
        /// 初始化建構式給定商品單價及數量
        /// </summary>
        public Product(double price, int num)
        {
            Price = price;
            Num = num;
        }
    }
}
