namespace Patterns_Practices_Principles.Patterns.Behavioral.State
{
    internal class Client
    {
        public static void ClientCode()
        {
            var context = new Context(new ConcreteStateA());
            context.request1();
            context.request2();
        }
    }
}