namespace Patterns_Practices_Principles.Patterns.Structural.Facade
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Client client = new Client();

            Subsystem1 s1 = new Subsystem1();
            Subsystem2 s2 = new Subsystem2();
            Facade facade = new Facade(s1, s2);
            client.ClientCode(facade);
        }
    }
}