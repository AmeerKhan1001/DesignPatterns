namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            User user = new UserBuilder()
                .WithUsername("davisdoe")
                .WithPassword("secure123")
                .WithEmail("john.doe@example.com")
                .WithFirstName("John")
                .WithLastName("Doe")
                .WithAddress("address")
                .WithCity("city")
                .WithState("state")
                .WithZipCode("12345")
                .WithPhoneNumber("123-456-7890")
                .Build();

            Console.WriteLine("User created using Builder Pattern:");
            Console.WriteLine(user);
        }
    }
}