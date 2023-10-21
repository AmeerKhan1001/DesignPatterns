namespace FactoryPattern
{
    public class PropertyTypes
    {
        public interface IProperty
        {
            void Build();
        }

        // Concrete product classes
        public class SingleFamily : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a single-family property.");
            }
        }

        public class Townhouse : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a townhouse property.");
            }
        }

        public class Apartment : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building an apartment property.");
            }
        }
    }
}
