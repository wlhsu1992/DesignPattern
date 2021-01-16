using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelExample
{
    /// <summary>
    /// 正常收費子類別
    /// </summary>
    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    /// <summary>
    /// 打折收費子類別
    /// </summary>
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate (string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    /// <summary>
    /// 紅利收費子類別
    /// </summary>
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="moneyCondition">紅利收費條件</param>
        /// <param name="moneyReturn">紅利值</param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        /// <summary>
        /// 紅利折扣計價方案 EX:消費滿300折100
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            return result;
        }
    }

}
