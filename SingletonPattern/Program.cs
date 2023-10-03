// Non-Singleton Class
public class NonSingleton
{
    public NonSingleton()
    {
        Console.WriteLine("Non-Singleton instance created.\n");
    }
}

// Singleton Class
public sealed class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Singleton instance created.\n");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Non-Singleton usage
        NonSingleton nonSingleton1 = new NonSingleton();

        NonSingleton nonSingleton2 = new NonSingleton();

        Console.WriteLine($"Are nonSingleton1 and nonSingleton2 the same instance => {ReferenceEquals(nonSingleton1, nonSingleton2)} \n");

        // Singleton usage
        Singleton singleton1 = Singleton.Instance;

        Singleton singleton2 = Singleton.Instance;

        Console.WriteLine($"Are singleton1 and singleton2 the same instance => {ReferenceEquals(singleton1, singleton2)}");

        Console.ReadKey();
    }
}

// Applications - Database Object Creation, Exception Logging 