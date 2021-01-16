using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
{
    class CashContext
    {
        private CashSuper cs;

        /// <summary>
        /// 建構式，傳入具體收費策略
        /// </summary>
        public CashContext(CashSuper csuper)
        {
            this.cs = csuper;
        }

        public double GetResult(double money)
        {
            // 根據收費策略的不同，獲得計算結果
            return cs.acceptCash(money);
        }
    }
}
