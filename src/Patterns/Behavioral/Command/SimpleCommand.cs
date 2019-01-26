using System;

namespace Patterns_Practices_Principles.Patterns.Behavioral.Command
{
    internal class SimpleCommand : Command
    {
        private string _payLoad = string.Empty;

        public SimpleCommand(string payLoad)
        {
            _payLoad = payLoad;
        }

        public override void Execute()
        {
            Console.Write($"SimpleCommand: See, I can do simple things like printing ({_payLoad})\n");
        }
    }
}