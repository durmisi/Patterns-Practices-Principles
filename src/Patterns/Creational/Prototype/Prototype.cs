using System;

namespace Patterns_Practices_Principles.Patterns.Creational.Prototype
{
    public class Prototype
    {
        public int Primitive { get; set; }

        public DateTime Component { get; set; }

        public ComponentWithBackReference CircularReference { get; set; }

        public Prototype()
        { }

        public Prototype Clone()
        {
            Prototype clone = this.MemberwiseClone() as Prototype;

            DateTime component0 = this.Component;
            DateTime component = component0;

            clone.Component = component;
            clone.CircularReference = this.CircularReference.CloneObject();

            clone.CircularReference.Prototype = this;

            return clone;
        }
    }

    public static class PrototypeHelper
    {
        public static T CloneObject<T>(this T obj) where T : class
        {
            if (obj == null) return null;
            System.Reflection.MethodInfo inst = obj.GetType().GetMethod("MemberwiseClone",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (inst != null)
                return (T)inst.Invoke(obj, null);
            else
                return null;
        }
    }
}