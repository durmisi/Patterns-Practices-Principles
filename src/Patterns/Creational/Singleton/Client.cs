using System;

namespace Patterns_Practices_Principles.Patterns.Creational.Singleton
{
    internal class Client
    {
        public void ClientCode()
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}