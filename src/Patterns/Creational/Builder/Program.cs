namespace Patterns_Practices_Principles.Patterns.Creational.Builder
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            Client client = new Client();
            client.ClientCode(director, builder);
        }
    }
}