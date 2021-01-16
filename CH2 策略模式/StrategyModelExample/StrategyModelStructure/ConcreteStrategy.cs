using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelStructure
{
    /// <summary>
    /// 具體演算法A
    /// </summary>
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("演算法A實現");
        }
    }

    /// <summary>
    /// 具體演算法B
    /// </summary>
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("演算法B實現");
        }
    }

    /// <summary>
    /// 具體演算法C
    /// </summary>
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("演算法C實現");
        }
    }
}
