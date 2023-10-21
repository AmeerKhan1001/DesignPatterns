using static AbstractFactory.FactoryClasses;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        public static IPropertyFactory CreatePropertyFactory(string propertyType)
        {
            switch (propertyType.ToLower())
            {
                case "singlefamily":
                    return new SingleFamilyFactory();

                case "mobile home":
                    return new MobileHomeFactory();

                case "apartment":
                    return new ApartmentFactory();

                default:
                    throw new ArgumentException("Invalid property type");
            }
        }
    }
}
