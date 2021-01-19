using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_polymorphism
{
    class OperationAdd : Operation
    {
        public override double GetResult(double numA, double numB)
        {
            return numA + numB;
        }
    }

    class OperationSub : Operation
    {
        public override double GetResult(double numA, double numB)
        {
            return numA - numB;
        }
    }

    class OperationMul : Operation
    {
        public override double GetResult(double numA, double numB)
        {
            return numA * numB;
        }
    }

    class OperationDiv : Operation
    {
        public override double GetResult(double numA, double numB)
        {
            if (numB == 0)
                throw new Exception("除數不能為0");
            return numA / numB;
        }
    }
}
