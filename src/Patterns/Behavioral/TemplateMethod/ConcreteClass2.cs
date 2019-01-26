using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.TemplateMethod
{
    internal class ConcreteClass2 : AbstractClass
    {
        protected override void requiredOperations1()
        {
            Console.Write("ConcreteClass2 says: Implemented Operation1\n");
        }

        protected override void requiredOperation2()
        {
            Console.Write("ConcreteClass2 says: Implemented Operation2\n");
        }

        protected override void hook1()
        {
            Console.Write("ConcreteClass2 says: Overridden Hook1\n");
        }
    }
}