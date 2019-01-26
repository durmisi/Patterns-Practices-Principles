namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal class Program
    {
        public void Main(string[] args)
        {
            var client = new Client();

            var abstraction = new ExtendedAbstraction(new ConcreteImplementorA());
            client.ClientCode(abstraction);

            abstraction.Implementor = new ConcreteImplementorB();
            client.ClientCode(abstraction);
        }
    }
}