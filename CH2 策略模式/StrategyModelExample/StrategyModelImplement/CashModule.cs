using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
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
        private double rebate = 1d;

        public CashRebate(double rebate)
        {
            this.rebate = rebate;
        }

        public override double acceptCash(double money)
        {
            return money * rebate;
        }
    }
    
    /// <summary>
    /// 紅利收費子類別
    /// </summary>
    class CashReturn : CashSuper
    {
        private double returnCondition = 0.0d;
        private double returnMoney = 0.0d;

        public CashReturn(double returnCondition, double returnMoney)
        {
            this.returnCondition = returnCondition;
            this.returnMoney = returnMoney;
        }

        public override double acceptCash(double money)
        {
            if (money > returnCondition)
                money = money - Math.Floor(money / returnCondition) * returnMoney;
            return money;
        }
    }
}
