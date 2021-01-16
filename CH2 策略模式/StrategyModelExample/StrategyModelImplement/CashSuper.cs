using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
{
    /// <summary>
    /// 現金收費抽象類別
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 現金收取超類別的抽象方法
        /// </summary>
        public abstract double acceptCash(double money);
    }
}
