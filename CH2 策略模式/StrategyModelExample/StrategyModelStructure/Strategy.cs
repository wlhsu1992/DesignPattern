using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelStructure
{
    /// <summary>
    /// 抽象演算法類別
    /// </summary>
    abstract class Strategy
    {
        /// <summary>
        /// 演算法方法
        /// </summary>
        public abstract void AlgorithmInterface();
    }
}
