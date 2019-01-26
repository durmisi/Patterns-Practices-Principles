namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal class ConcreteImplementorB : Implementor
    {
        public override string operationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}