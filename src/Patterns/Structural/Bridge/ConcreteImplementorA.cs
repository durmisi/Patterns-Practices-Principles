namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal class ConcreteImplementorA : Implementor
    {
        public override string operationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}