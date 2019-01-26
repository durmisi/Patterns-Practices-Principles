using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Command
{
    internal class Receiver
    {
        public void doSomething(string a)
        {
            Console.Write("Receiver: Working on (" + a + ".)\n");
        }

        public void doSomethingElse(string b)
        {
            Console.Write("Receiver: Also working on (" + b + ".)\n");
        }
    }
}