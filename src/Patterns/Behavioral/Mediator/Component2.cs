using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Mediator
{
    internal class Component2 : BaseComponent
    {
        public void doC()
        {
            Console.Write("Component 2 does C.\n");

            this.mediator.notify(this, "C");
        }

        public void doD()
        {
            Console.Write("Component 2 does D.\n");

            this.mediator.notify(this, "D");
        }
    }
}