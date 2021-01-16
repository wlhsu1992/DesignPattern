using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelImplement
{
    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

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
