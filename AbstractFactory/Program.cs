using static AbstractFactory.FactoryClasses;
using static AbstractFactory.PropertyTypes;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            string propertyType = "mobile home";
            string style = "modern";

            #region Approach without abstract factory

            if (propertyType == "singlefamily")
            {
                if (style == "traditional")
                {
                    // Code to produce a traditional single-family home
                    Console.WriteLine("Producing a traditional single-family home.");
                }
                else if (style == "modern")
                {
                    // Code to produce a modern single-family home
                    Console.WriteLine("Producing a modern single-family home.");
                }
                else if (style == "rustic")
                {
                    // Code to produce a rustic single-family home
                    Console.WriteLine("Producing a rustic single-family home.");
                }
                else
                {
                    // Handle invalid style for single-family homes
                    Console.WriteLine("Invalid style for single-family homes.");
                }
            }
            else if (propertyType == "mobile home")
            {
                if (style == "traditional")
                {
                    // Code to produce a traditional mobile home
                    Console.WriteLine("Producing a traditional mobile home.");
                }
                else if (style == "modern")
                {
                    // Code to produce a modern mobile home
                    Console.WriteLine("Producing a modern mobile home.");
                }
                else if (style == "rustic")
                {
                    // Code to produce a rustic mobile home
                    Console.WriteLine("Producing a rustic mobile home.");
                }
                else
                {
                    // Handle invalid style for mobile homes
                    Console.WriteLine("Invalid style for mobile homes.");
                }
            }
            else if (propertyType == "apartment")
            {
                if (style == "traditional")
                {
                    // Code to produce a traditional apartment
                    Console.WriteLine("Producing a traditional apartment.");
                }
                else if (style == "modern")
                {
                    // Code to produce a modern apartment
                    Console.WriteLine("Producing a modern apartment.");
                }
                else if (style == "rustic")
                {
                    // Code to produce a rustic apartment
                    Console.WriteLine("Producing a rustic apartment.");
                }
                else
                {
                    // Handle invalid style for apartments
                    Console.WriteLine("Invalid style for apartments.");
                }
            }
            else
            {
                // Handle invalid property type
                Console.WriteLine("Invalid property type.");
            }
            #endregion

            #region Approach with abstract factory

            IPropertyFactory propertyFactory = AbstractFactory.CreatePropertyFactory(propertyType);
            IProperty property = propertyFactory.CreateProperty(style);
            property.Build();

            // Output: Building a modern mobile home.
            #endregion

        }
    }
}
