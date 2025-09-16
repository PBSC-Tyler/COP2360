using System;

public class Panda
{
    private string name;
      public Panda(string n)
    {
        name = n;
        Console.WriteLine($"A new panda named {name} has been created!");      
    }
}

Panda p = new Panda ("Petey");   // Call constructor

public class Panda
{
  string name;                   // Define field
  public Panda (string n)        // Define constructor
  {
    name = n;                    // Initialization code (set up field)
  }
}
Constructors - Overloading

// You can also overload constructors.
