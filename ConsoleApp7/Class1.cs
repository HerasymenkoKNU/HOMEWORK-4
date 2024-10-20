using System;
public interface IGeographicalObject
{
    void Information();
}

class Program
{
    static void Main(string[] args)
    {

        River river = new River
        {
            X = 23.4872,
            Y = 21.849,
            Name = "Some river",
            Description = "Some descriprion of river",
            Speed = 1000000,
            Length = 132320801
        };

        river.Information();


        Mountain mountain = new Mountain
        {
            X = 197.79230,
            Y = 8372.32070,
            Name = "Some name",
            Description = "Some description of mountain",
            Peak = 9749729711
        };

        mountain.Information();

        Console.ReadKey();
    }
}