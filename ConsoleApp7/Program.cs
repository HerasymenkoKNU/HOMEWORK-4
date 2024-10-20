using System;
public abstract class GeographicalObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }


    public virtual void Information()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Info: {Description}");
        Console.WriteLine($"Cords: ({X}, {Y})");
    }
}


public class River : GeographicalObject
{
    public double Speed { get; set; }
    public double Length { get; set; }

    public override void Information()
    {
        base.Information();

        Console.WriteLine($"Speed of flow: {Speed} см/с");
        Console.WriteLine($"Total length: {Length} ");

    }
}

public class Mountain : GeographicalObject
{
    public double Peak { get; set; }

    public override void Information()
    {
        base.Information();
        Console.WriteLine($"Peak: {Peak}");
    }
}

