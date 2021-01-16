using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CashSystem
{
    public class Product
    {
        public double Price { get; }
        public int Num { get; }

        public Product(double price, int num)
        {
            Price = price;
            Num = num;
        }
    }
}
