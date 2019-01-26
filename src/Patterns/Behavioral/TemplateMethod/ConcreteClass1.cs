﻿using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.TemplateMethod
{
    internal class ConcreteClass1 : AbstractClass
    {
        protected override void requiredOperations1()
        {
            Console.Write("ConcreteClass1 says: Implemented Operation1\n");
        }

        protected override void requiredOperation2()
        {
            Console.Write("ConcreteClass1 says: Implemented Operation2\n");
        }
    }
}