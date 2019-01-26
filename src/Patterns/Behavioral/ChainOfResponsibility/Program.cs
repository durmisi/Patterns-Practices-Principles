using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.ChainOfResponsibility
{
    internal class Program
    {
        public void Main(string[] args)
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.setNext(squirrel).setNext(dog);

            Console.WriteLine("Chain: Monkey > Squirerel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}