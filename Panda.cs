
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

class Program
{
    static void Main(string[] args)
    {
        Panda po = new Panda("Po");
    }
}
