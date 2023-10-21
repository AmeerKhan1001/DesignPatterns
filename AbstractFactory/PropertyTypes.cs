namespace AbstractFactory
{
    public class PropertyTypes
    {
        // Abstract product interface
        public interface IProperty
        {
            void Build();
        }

        // Concrete product classes
        public class TraditionalSingleFamily : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a traditional single-family home.");
            }
        }

        public class ModernSingleFamily : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a modern single-family home.");
            }
        }

        public class RusticSingleFamily : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a rustic single-family home.");
            }
        }

        public class TraditionalMobileHome : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a traditional mobile home.");
            }
        }

        public class ModernMobileHome : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a modern mobile home.");
            }
        }

        public class RusticMobileHome : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a rustic mobile home.");
            }
        }

        public class TraditionalApartment : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a traditional apartment.");
            }
        }

        public class ModernApartment : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a modern apartment.");
            }
        }

        public class RusticApartment : IProperty
        {
            public void Build()
            {
                Console.WriteLine("Building a rustic apartment.");
            }
        }
    }
}
