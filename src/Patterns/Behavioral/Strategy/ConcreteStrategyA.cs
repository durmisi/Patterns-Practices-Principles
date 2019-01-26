using System.Collections.Generic;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Strategy
{
    internal class ConcreteStrategyA : Strategy
    {
        public object doAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}