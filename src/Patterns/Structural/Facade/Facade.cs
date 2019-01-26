namespace Patterns_Practices_Principles.Patterns.Structural.Facade
{
    public class Facade
    {
        private Subsystem1 Subsystem1;

        private Subsystem2 Subsystem2;

        public Facade(Subsystem1 s1, Subsystem2 s2)
        {
            this.Subsystem1 = s1;
            this.Subsystem2 = s2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += Subsystem1.operation1();
            result += Subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += Subsystem1.operationN();
            result += Subsystem2.operationZ();
            return result;
        }
    }
}