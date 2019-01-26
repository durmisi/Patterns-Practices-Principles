namespace Patterns_Practices_Principles.Patterns.Behavioral.Mediator
{
    internal interface Mediator
    {
        void notify(object sender, object ev);
    }
}