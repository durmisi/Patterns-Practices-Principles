namespace Patterns_Practices_Principles.Patterns.Creational.FactoryMethod
{
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}