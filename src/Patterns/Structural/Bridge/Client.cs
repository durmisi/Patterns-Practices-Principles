using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}