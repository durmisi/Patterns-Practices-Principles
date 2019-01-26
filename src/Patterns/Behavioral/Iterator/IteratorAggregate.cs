using System.Collections;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Iterator
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}