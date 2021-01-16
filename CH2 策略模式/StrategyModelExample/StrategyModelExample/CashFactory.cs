using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryModelSolution
{
    /// <summary>
    /// 現金收費工廠類別
    /// </summary>
    class CashFactory
    {
        /// <summary>
        /// 根據輸入決定產生CashSuper子類別
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;
                case "滿300送100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
            return cs;
        }
    }
}
