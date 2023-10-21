namespace FactoryPattern
{
    public class PropertyFactory
    {
        public static IProperty CreateProperty(string propertyType)
        {
            switch (propertyType.ToLower())
            {
                case "singlefamily":
                    return new SingleFamily();
                case "townhouse":
                    return new Townhouse();
                case "apartment":
                    return new Apartment();
                default:
                    throw new ArgumentException("Invalid property type");
            }
        }
    }
}
