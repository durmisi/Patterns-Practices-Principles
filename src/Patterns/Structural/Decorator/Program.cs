using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Decorator
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a sumple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            ConcreteDecoratorA d1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB d2 = new ConcreteDecoratorB(d1);
            Console.WriteLine("Client: Now I get a decorated component:");
            client.ClientCode(d2);
        }
    }
}