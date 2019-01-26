namespace Patterns_Practices_Principles.Patterns.Behavioral.Command
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.setOnStart(new SimpleCommand("Say Hi!"));
            Receiver r = new Receiver();
            invoker.setOnFinish(new ComplexCommand(r, "Send email", "Save report"));

            invoker.doSomethingImportant();
        }
    }
}