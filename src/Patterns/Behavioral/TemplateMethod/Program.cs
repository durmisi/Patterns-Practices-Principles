using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.TemplateMethod
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Same client code can work with different subclasses:\n");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");
            Console.Write("Same client code can work with different subclasses:\n");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}