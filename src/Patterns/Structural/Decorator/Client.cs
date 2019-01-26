using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Decorator
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}