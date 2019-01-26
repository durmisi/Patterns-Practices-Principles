using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Proxy
{
    internal class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if (this.checkAccess())
            {
                realSubject = new RealSubject();
                realSubject.Request();

                this.logAccess();
            }
        }

        public bool checkAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void logAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}