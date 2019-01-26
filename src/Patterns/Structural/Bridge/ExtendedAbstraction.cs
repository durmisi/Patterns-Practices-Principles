namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(Implementor imp) : base(imp)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" + base.implementor.operationImplementation();
        }
    }
}