namespace Patterns_Practices_Principles.Patterns.Structural.Proxy
{
    public class Client
    {
        public void ClientCode(Subject subject)
        {
            subject.Request();
        }
    }
}