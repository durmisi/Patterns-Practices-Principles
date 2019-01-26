namespace Patterns_Practices_Principles.Patterns.Creational.Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void buildMinimalViableProduct()
        {
            builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}