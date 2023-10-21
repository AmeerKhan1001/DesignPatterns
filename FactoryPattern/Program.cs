using FactoryPattern;
using static FactoryPattern.PropertyTypes;

class Program
{
    static void Main()
    {
        string propertyRequest = "apartment";
        IProperty propertyObject;

        #region Approach without factory

        switch (propertyRequest.ToLower())
        {
            case "singlefamily":
                propertyObject = new SingleFamily();
                break;
            case "townhouse":
                propertyObject = new Townhouse();
                break;
            case "apartment":
                propertyObject = new Apartment();
                break;
            default:
                throw new ArgumentException("Invalid property type");
        }

        propertyObject.Build();

        // Output: Building an apartment property.

        #endregion

        #region Approach with factory

        propertyObject = PropertyFactory.CreateProperty(propertyRequest);
        propertyObject.Build();

        // Output: Building an apartment property.

        #endregion
    }
}
