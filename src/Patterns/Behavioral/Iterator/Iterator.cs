﻿using System.Collections;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Iterator
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}