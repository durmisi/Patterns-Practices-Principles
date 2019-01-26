namespace Patterns_Practices_Principles.Patterns.Behavioral.TemplateMethod
{
    internal class Client
    {
        public static void ClientCode(AbstractClass ac)
        {
            ac.templateMethod();
        }
    }
}