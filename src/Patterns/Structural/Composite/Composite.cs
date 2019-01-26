using System;
using System.Collections.Generic;

namespace Patterns_Practices_Principles.Patterns.Structural.Composite
{
    internal class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite()
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override void Operation()
        {
            int i = 0;

            Console.Write("Branch(");
            foreach (Component component in children)
            {
                component.Operation();
                if (i != children.Count - 1)
                {
                    Console.Write("+");
                }
                i++;
            }
            Console.Write(")");
        }
    }
}