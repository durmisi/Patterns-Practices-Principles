using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Observer
{
    internal class ConcreteObserverA : SplObserver
    {
        public void update(SplSubject subject)
        {
            if (!(subject is Subject))
            {
                return;
            }

            if ((subject as Subject).State < 3)
            {
                Console.Write("ConcreteObserverA: Reacted to the event.\n");
            }
        }
    }
}