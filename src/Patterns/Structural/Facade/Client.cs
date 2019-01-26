using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Facade
{
    internal class Client
    {
        internal void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}