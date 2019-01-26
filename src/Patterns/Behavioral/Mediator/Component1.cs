using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Mediator
{
    internal class Component1 : BaseComponent
    {
        public void doA()
        {
            Console.Write("Component 1 does A.\n");

            this.mediator.notify(this, "A");
        }

        public void doB()
        {
            Console.Write("Component 1 does B.\n");

            this.mediator.notify(this, "B");
        }
    }
}