namespace Patterns_Practices_Principles.Patterns.Behavioral.Observer
{
    public interface SplSubject
    {
        void attach(SplObserver observer);

        void detach(SplObserver observer);

        void notify();
    }
}