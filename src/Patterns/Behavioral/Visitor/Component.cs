namespace Patterns_Practices_Principles.Patterns.Behavioral.Visitor
{
    internal interface Component
    {
        void accept(Visitor visitor);
    }
}