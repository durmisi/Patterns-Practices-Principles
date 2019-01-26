﻿using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Composite
{
    internal class Leaf : Component
    {
        public Leaf()
        {
        }

        public override void Operation()
        {
            Console.Write("LEAF");
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}