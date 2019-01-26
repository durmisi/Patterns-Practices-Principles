using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Composite
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Client client = new Client();

            Component leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);
            Console.WriteLine("\n");

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I get a composite tree:");
            client.ClientCode(tree);
            Console.WriteLine("\n");

            Console.Write("Client: I can merge two components without checking their classes:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}