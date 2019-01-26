using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Proxy
{
    internal class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}