using System.Collections.Generic;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Strategy
{
    internal class ConcreteStrategyB : Strategy
    {
        public object doAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}