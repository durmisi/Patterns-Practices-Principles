namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    public class ConcreteComponentB : Component
    {
        public void accept(Visitor visitor)
        {
            visitor.visitConcreteComponentB(this);
        }

        public string specialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}