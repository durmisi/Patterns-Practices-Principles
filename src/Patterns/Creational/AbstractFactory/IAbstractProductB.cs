namespace Patterns_Practices_Principles.Patterns.Creational.AbstractFactory
{
    internal interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}