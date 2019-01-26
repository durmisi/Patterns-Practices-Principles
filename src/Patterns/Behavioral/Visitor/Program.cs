using System;
using System.Collections.Generic;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    internal class Program
    {
        public void Main(string[] args)
        {
            List<Component> components = new List<Component>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.Write("The client code works with all visitors via the base Visitor interface:\n");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.Write("It allows the same client code to work with different types of visitors:\n");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}