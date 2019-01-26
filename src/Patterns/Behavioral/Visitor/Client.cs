using System.Collections.Generic;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    internal class Client
    {
        internal static void ClientCode(List<Component> components, Visitor visitor)
        {
            foreach (var component in components)
            {
                component.accept(visitor);
            }
        }
    }
}