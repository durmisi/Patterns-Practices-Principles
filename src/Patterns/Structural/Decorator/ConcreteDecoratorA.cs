namespace Patterns_Practices_Principles.Patterns.Structural.Decorator
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return "ConcreteDecoratorA(" + base.Operation() + ")";
        }
    }
}