using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OperationAdd : BaseOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    class OperationSub : BaseOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    class OperationMul : BaseOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class OperationDiv : BaseOperation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0) throw new Exception("除數不可為0");
            result = NumberA / NumberB;
            return result;
        }
    }
}
