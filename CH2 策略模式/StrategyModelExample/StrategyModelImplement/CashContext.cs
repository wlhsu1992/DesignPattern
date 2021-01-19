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
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;
                case "滿300送100":
                    cs = new CashReturn(300, 100);
                    break;
                case "打8折":
                    cs = new CashRebate(0.8);
                    break;
            }
        }

    public double GetResult(double money)
        {
            // 根據收費策略的不同，獲得計算結果
            return cs.acceptCash(money);
        }
    }
}
