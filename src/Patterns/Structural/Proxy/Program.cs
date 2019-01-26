using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Proxy
{
    internal class Program
    {
        private void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Client: Executing the client code with a real subject:");

            RealSubject realSubject = new RealSubject();

            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");

            Proxy proxy = new Proxy();

            client.ClientCode(proxy);
        }
    }
}