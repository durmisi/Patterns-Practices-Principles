namespace Patterns_Practices_Principles.Patterns.Creational.FactoryMethod
{
    internal class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}