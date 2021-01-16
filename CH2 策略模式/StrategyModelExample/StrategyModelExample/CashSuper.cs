using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryModelSolution
{
    /// <summary>
    /// 現金收費抽象類別
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 計算商品應收現金
        /// </summary>
        /// <param name="money">商品原始價格</param>
        /// <returns></returns>
        public abstract double acceptCash(double money);
    }
}
