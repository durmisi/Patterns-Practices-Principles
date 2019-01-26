using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Command
{
    internal class Invoker
    {
        private Command onStart;

        private Command onFinish;

        public void setOnStart(Command c)
        {
            onStart = c;
        }

        public void setOnFinish(Command c)
        {
            onFinish = c;
        }

        public void doSomethingImportant()
        {
            Console.Write("Invoker: Does anybody want something done before I begin?\n");
            if (onStart is Command)
            {
                onStart.Execute();
            }
            Console.Write("Invoker: ...doing something really important...\n");
            Console.Write("Invoker: Does anybody want something done after I finish?\n");
            if (onFinish is Command)
            {
                onFinish.Execute();
            }
        }
    }
}