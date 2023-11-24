using System;

public class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Continent { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public Country(string name, string capital, string continent, int population, double area)
    {
        Name = name;
        Capital = capital;
        Continent = continent;
        Population = population;
        Area = area;
    }

    // Method to display country information
    public void DisplayInfo()
    {
        Console.WriteLine($"Country: {Name}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Continent: {Continent}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Area: {Area} square kilometers");
    }

    // Method to calculate population density
    public double CalculatePopulationDensity()
    {
        return Population / Area;
    }

    // Method to check if the country is in a specific continent
    public bool IsInContinent(string targetContinent)
    {
        return string.Equals(Continent, targetContinent, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        Country Nigeria = new Country("Nigeria", "Abuja", "Africa", 218541212, 923768);
        Nigeria.DisplayInfo();

        double populationDensity = Nigeria.CalculatePopulationDensity();
        Console.WriteLine($"Population Density: {populationDensity} people per square kilometer");

        bool isAfrica = Nigeria.IsInContinent("Africa");
        Console.WriteLine($"Is in Afica: {isAfrica}");
    }
}