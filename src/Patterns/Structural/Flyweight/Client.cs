using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Flyweight
{
    public class Client
    {
        public void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.Write("\nClient: Adding a car to database.\n");

            var flyweight = factory.GetFlyweight(new Car { Color = car.Color, Model = car.Model, Company = car.Company });
            flyweight.Operation(car);
        }

        public void ClientCode()
        {
            var factory = new FlyweightFactory
                (
                    new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                    new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                    new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                    new Car { Company = "BMW", Model = "M5", Color = "red" },
                    new Car { Company = "BMW", Model = "X6", Color = "white" }
                );
            factory.listFlyweights();

            addCarToPoliceDatabase(factory,
                new Car
                {
                    Number = "CL234IR",
                    Owner = "James Doe",
                    Company = "BMW",
                    Model = "M5",
                    Color = "red"
                });

            addCarToPoliceDatabase(factory,
                new Car
                {
                    Number = "CL234IR",
                    Owner = "James Doe",
                    Company = "BMW",
                    Model = "X1",
                    Color = "red"
                });

            factory.listFlyweights();
        }
    }
}