using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Memento
{
    internal interface Memento
    {
        string getName();

        string getState();

        DateTime getDate();
    }
}