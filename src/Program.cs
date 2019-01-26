using System;

namespace Patterns_Practices_Principles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            Console.WriteLine("======================Factory Method==================================");
            new Patterns.Creational.FactoryMethod.Program().Main(args);

            Console.WriteLine("======================Abstract Factory==================================");
            new Patterns.Creational.AbstractFactory.Program().Main(args);

            Console.WriteLine("======================Builder==================================");
            new Patterns.Creational.Builder.Program().Main(args);

            Console.WriteLine("======================Prototype==================================");
            new Patterns.Creational.Prototype.Program().Main(args);

            Console.WriteLine("======================Singleton==================================");
            new Patterns.Creational.Singleton.Program().Main(args);

            Console.WriteLine("========================================================");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            Console.WriteLine("======================Adapter==================================");
            new Patterns.Structural.Adapter.Program().Main(args);

            Console.WriteLine("======================Bridge==================================");
            new Patterns.Structural.Bridge.Program().Main(args);

            Console.WriteLine("======================Composite==================================");
            new Patterns.Structural.Composite.Program().Main(args);

            Console.WriteLine("======================Decorator==================================");
            new Patterns.Structural.Decorator.Program().Main(args);

            Console.WriteLine("======================Facade==================================");
            new Patterns.Structural.Facade.Program().Main(args);

            Console.WriteLine("======================Flyweight==================================");
            new Patterns.Structural.Flyweight.Program().Main(args);

            Console.WriteLine("========================================================");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            Console.WriteLine("======================Chain Of Responsibility==================================");
            new Patterns.Behavioral.ChainOfResponsibility.Program().Main(args);

            Console.WriteLine("======================Command==================================");
            new Patterns.Behavioral.Command.Program().Main(args);

            Console.WriteLine("======================Iterator==================================");
            new Patterns.Behavioral.Iterator.Program().Main(args);

            Console.WriteLine("======================Mediator==================================");
            new Patterns.Behavioral.Mediator.Program().Main(args);

            Console.WriteLine("======================Memento==================================");
            new Patterns.Behavioral.Memento.Program().Main(args);

            Console.WriteLine("======================Observer==================================");
            new Patterns.Behavioral.Observer.Program().Main(args);

            Console.WriteLine("======================State==================================");
            new Patterns.Behavioral.State.Program().Main(args);

            Console.WriteLine("======================Strategy==================================");
            new Patterns.Behavioral.Strategy.Program().Main(args);

            Console.WriteLine("======================Template Method==================================");
            new Patterns.Behavioral.TemplateMethod.Program().Main(args);

            Console.WriteLine("======================Visitor==================================");
            new Patterns.Behavioral.Visitor.Program().Main(args);

            Console.ReadLine();
        }
    }
}