namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    public interface Visitor
    {
        void visitConcreteComponentA(ConcreteComponentA el);

        void visitConcreteComponentB(ConcreteComponentB el);
    }
}