namespace Patterns_Practices_Principles.Patterns.Structural.Bridge
{
    internal abstract class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + implementor.operationImplementation();
        }
    }
}