namespace Patterns_Practices_Principles.Patterns.Behavioral.ChainOfResponsibility
{
    internal interface Handler
    {
        Handler setNext(Handler handler);

        object Handle(object request);
    }
}