namespace Patterns_Practices_Principles.Patterns.Structural.Composite
{
    internal abstract class Component
    {
        public Component()
        {
        }

        public abstract void Operation();

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract bool IsComposite();
    }
}