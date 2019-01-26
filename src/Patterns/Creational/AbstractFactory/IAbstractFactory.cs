namespace Patterns_Practices_Principles.Patterns.Creational.AbstractFactory
{
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}