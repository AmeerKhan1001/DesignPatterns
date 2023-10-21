using static AbstractFactory.PropertyTypes;

namespace AbstractFactory
{
    public class FactoryClasses
    {
        // Abstract factory interface
        public interface IPropertyFactory
        {
            IProperty CreateProperty(string style);
        }

        public class SingleFamilyFactory : IPropertyFactory
        {
            public IProperty CreateProperty(string style)
            {
                switch (style.ToLower())
                {
                    case "traditional":
                        return new TraditionalSingleFamily();
                    case "modern":
                        return new ModernSingleFamily();
                    case "rustic":
                        return new RusticSingleFamily();
                    default:
                        throw new ArgumentException("Invalid style");
                }
            }
        }

        public class MobileHomeFactory : IPropertyFactory
        {
            public IProperty CreateProperty(string style)
            {
                switch (style.ToLower())
                {
                    case "traditional":
                        return new TraditionalMobileHome();
                    case "modern":
                        return new ModernMobileHome();
                    case "rustic":
                        return new RusticMobileHome();
                    default:
                        throw new ArgumentException("Invalid style");
                }
            }
        }

        public class ApartmentFactory : IPropertyFactory
        {
            public IProperty CreateProperty(string style)
            {
                switch (style.ToLower())
                {
                    case "traditional":
                        return new TraditionalApartment();
                    case "modern":
                        return new ModernApartment();
                    case "rustic":
                        return new RusticApartment();
                    default:
                        throw new ArgumentException("Invalid style");
                }
            }
        }
    }
}
