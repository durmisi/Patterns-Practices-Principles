namespace Patterns_Practices_Principles.Patterns.Structural.Decorator
{
    internal class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return "ConcreteDecoratorB(" + base.Operation() + ")";
        }
    }
}