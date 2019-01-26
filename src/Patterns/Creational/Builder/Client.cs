using System;

namespace Patterns_Practices_Principles.Patterns.Creational.Builder
{
    public class Client
    {
        public void ClientCode(Director director, Builder builder)
        {
            Console.WriteLine("Standart basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standart full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}