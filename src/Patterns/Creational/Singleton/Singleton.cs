namespace Patterns_Practices_Principles.Patterns.Creational.Singleton
{
    internal class Singleton
    {
        private static Singleton instance;

        private static object obj = new object();

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            lock (obj)
            {
                if (instance == null)
                    instance = new Singleton();
            }

            return instance;
        }
    }
}