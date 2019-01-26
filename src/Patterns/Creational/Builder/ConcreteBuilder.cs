namespace Patterns_Practices_Principles.Patterns.Creational.Builder
{
    public class ConcreteBuilder : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("PartA1");
        }

        public override void BuildPartB()
        {
            product.Add("PartB1");
        }

        public override void BuildPartC()
        {
            product.Add("PartC1");
        }

        public override Product GetProduct()
        {
            Product result = product;

            this.Reset();

            return result;
        }

        public void Reset()
        {
            product = new Product();
        }
    }
}