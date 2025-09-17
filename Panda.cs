using System;

public class Panda
{
    // Constant: All pandas have this value (e.g., number of eyes)
    public const int Eyes = 2;

    // Static readonly: Shared value, set once (e.g., number of ears)
    public static readonly int Ears = 2;

    // Instance fields/properties (customize as needed)
    public string Name { get; set; }
    public string Species { get; set; }
    public bool LikesBamboo { get; set; }
    public bool IsPlayful { get; set; }
    public double WeightKg { get; set; }

    // Default constructor
    public Panda() 
    { 
        Name = "Unknown";
        Species = "Unknown";   
    }        
    // Overloaded constructor
    public Panda(string name, string species, double weightKg)
    {
        Name = name;
        Species = species;
        WeightKg = weightKg;
    }

    // Method overloading example
    public void Eat(int bambooStalks)
    {
        Console.WriteLine($"{Name} ate {bambooStalks} bamboo stalks!");
    }

    public void Eat(double grams)
    {
        Console.WriteLine($"{Name} ate {grams} grams of bamboo!");
    }

    // Helper method
    public double BambooIntake()
    {
        // Example formula; adjust as needed!
        return 50 + 4 * WeightKg;
    }

    // Describe method
    public void Describe()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Eyes: {Eyes}, Ears: {Ears}");
        Console.WriteLine($"Likes Bamboo: {LikesBamboo}, Is Playful: {IsPlayful}");
        Console.WriteLine($"Recommended daily bamboo intake: {BambooIntake()} grams");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Object initializer
        var ping = new Panda
        {
            Name = "Ping",
            Species = "Giant Panda",
            LikesBamboo = true,
            IsPlayful = true,
            WeightKg = 95.0
        };

        // Constructor with parameters
        var ling = new Panda("Ling", "Red Panda", 6.2)
        {
            LikesBamboo = true,
            IsPlayful = false
        };

        ping.Describe();
        ling.Describe();

        ping.Eat(12);      // Ping eats bamboo stalks
        ling.Eat(340.5);   // Ling eats by grams
    }
}
