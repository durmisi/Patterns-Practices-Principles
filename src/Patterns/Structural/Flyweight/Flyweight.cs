using Newtonsoft.Json;
using System;

namespace Patterns_Practices_Principles.Patterns.Structural.Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.Write($"Flyweight: Displaying shared {s} and unique {u} state.\n");
        }
    }
}