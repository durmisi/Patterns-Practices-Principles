namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    public class ConcreteComponentA : Component
    {
        public void accept(Visitor visitor)
        {
            visitor.visitConcreteComponentA(this);
        }

        public string exclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}