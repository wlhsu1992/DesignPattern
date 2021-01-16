using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModelStructure
{
    /// <summary>
    /// 上下文
    /// </summary>
    class Context
    {
        Strategy strategy;

        /// <summary>
        /// 初始化時傳入具體策略物件
        /// </summary>
        public Context (Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 上下文介面
        /// </summary>
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
