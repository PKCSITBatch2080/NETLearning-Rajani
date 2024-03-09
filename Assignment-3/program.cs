using System;

class Program
{
    static void Main(string[] args)
    {
        var analysis = new InflationAnalysis();
        analysis.ReadCSV(@"Assignment 3\Inflation.csv");
        using System;

class Program
{
    static void Main(string[] args)
    {
        var analysis = new InflationAnalysis();
        analysis.ReadCSV(@"Assignment 3\Inflation.csv");

        // Query 1: Inflation rates for countries for the year 2021
        var inflation2021 = analysis.InflationRatesForYear(2021);
        Console.WriteLine("Inflation rates for countries for the year 2021:");
        foreach (var inflation in inflation2021)
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.Inflation}");
        }
        Console.WriteLine();

        // Query 2: A year when Nepal has the highest inflation
        var highestInflationYear = analysis.HighestInflationYearForNepal();
        Console.WriteLine($"Year with the highest inflation in Nepal: {highestInflationYear}");
        Console.WriteLine();

        // Query 3: List top 10 regions (countries) where inflation is highest for all time
        var topCountries = analysis.TopCountriesHighestInflation();
        Console.WriteLine("Top 10 countries with highest inflation:");
        foreach (var country in topCountries)
        {
            Console.WriteLine($"{country.Key}: {country.Value}");
        }
        Console.WriteLine();

        // Query 4: List top 3 south Asian countries with the lowest inflation rate for the year 2020
        var lowestInflation2020 = analysis.TopSouthAsianCountriesLowestInflation(2020);
        Console.WriteLine("Top 3 South Asian countries with lowest inflation in 2020:");
        foreach (var country in lowestInflation2020)
        {
            Console.WriteLine($"{country.Key}: {country.Value}");
        }
    }
}

        

    }
}
