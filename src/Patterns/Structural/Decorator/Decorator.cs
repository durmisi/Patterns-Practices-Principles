namespace Patterns_Practices_Principles.Patterns.Structural.Decorator
{
    internal abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override string Operation()
        {
            if (component != null)
            {
                return component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}