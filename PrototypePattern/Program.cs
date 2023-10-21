using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    // Important Terms
    //1. Prototype: The prototype is the object that serves as a template for creating other objects.
    //2. Cloning: Making copies of the prototype object. The copy process can be a shallow or deep copy, depending on the requirements.

    // Shallow copy - it copies references to the inner objects.
    // Deep copy - it creates new objects for all references, recursively.

    // Define a class that represents a product
    class Product : ICloneable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public object Clone()
        {
            // Perform a shallow copy for the Product object
            return this.MemberwiseClone();
        }

        public Product DeepCopy()
        {
            // Perform a deep copy for the Product object
            return new Product(Name, Price);
        }
    }

    // Define a class for items in a shopping cart
    class CartItem : ICloneable
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public object Clone()
        {
            // Perform a shallow copy for the CartItem object, including the nested Product
            return this.MemberwiseClone();
        }

        public CartItem DeepCopy()
        {
            // Perform a deep copy for the CartItem object, including the nested Product
            return new CartItem(Product.DeepCopy(), Quantity);
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a prototype CartItem
            var prototypeItem = new CartItem(new Product("Apple", 1), 5);

            // Perform a shallow copy to create a new CartItem
            var shallowCopiedItem = (CartItem)prototypeItem.Clone();

            // Perform a deep copy to create another CartItem
            var deepCopiedItem = prototypeItem.DeepCopy();

            // Modify the shallow copy, affecting the original due to shared references
            shallowCopiedItem.Quantity = 10;
            shallowCopiedItem.Product.Name = "Banana"; // Modify the nested Product

            Console.WriteLine("Original Prototype Item: Product - " + prototypeItem.Product.Name + ", Quantity - " + prototypeItem.Quantity);
            Console.WriteLine("Shallow Copied Item: Product - " + shallowCopiedItem.Product.Name + ", Quantity - " + shallowCopiedItem.Quantity);
            Console.WriteLine("Deep Copied Item: Product - " + deepCopiedItem.Product.Name + ", Quantity - " + deepCopiedItem.Quantity);

            // Output

            // Original Prototype Item: Product - Banana, Quantity - 5
            // Shallow Copied Item: Product - Banana, Quantity - 10
            // Deep Copied Item: Product - Apple, Quantity - 5
        }
    }
}
