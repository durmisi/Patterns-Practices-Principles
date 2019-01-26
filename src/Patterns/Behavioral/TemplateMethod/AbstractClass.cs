using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.TemplateMethod
{
    internal abstract class AbstractClass
    {
        public void templateMethod()
        {
            this.baseOperation1();
            this.requiredOperations1();
            this.baseOperation2();
            this.hook1();
            this.requiredOperation2();
            this.baseOperation3();
            this.hook2();
        }

        protected void baseOperation1()
        {
            Console.Write("AbstractClass says: I am doing the bulk of the work\n");
        }

        protected void baseOperation2()
        {
            Console.Write("AbstractClass says: But I let subclasses override some operations\n");
        }

        protected void baseOperation3()
        {
            Console.Write("AbstractClass says: But I am doing the bulk of the work anyway\n");
        }

        protected abstract void requiredOperations1();

        protected abstract void requiredOperation2();

        protected virtual void hook1()
        {
        }

        protected virtual void hook2()
        {
        }
    }
}