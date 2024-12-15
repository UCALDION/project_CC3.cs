using System;

class Vehicle
{
    protected string brand;
    protected string model;
    protected int year;

    public Vehicle(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}\nModel: {model}\nYear: {year}");
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("Engine starting...");


    }
}

class Car : Vehicle
{
    private int numberOfSeats;
    private bool hasSunroof;

    public Car(string brand, string model, int year, int numberOfSeats, bool hasSunroof)
        : base(brand, model, year)
    {
        this.numberOfSeats = numberOfSeats;
        this.hasSunroof = hasSunroof;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Seats: {numberOfSeats}\nHas Sunroof: {(hasSunroof ? "Yes" : "No")}");
    }
}

class Boat : Vehicle
{
    private string hullMaterial;
    private double draft;

    public Boat(string brand, string model, int year, string hullMaterial, double draft)
        : base(brand, model, year)
    {
        this.hullMaterial = hullMaterial;
        this.draft = draft;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Hull Material: {hullMaterial}\nDraft: {draft} meters");
    }
}

class Airplane : Vehicle
{
    private double wingspan;
    private int maxAltitude;

    public Airplane(string brand, string model, int year, double wingspan, int maxAltitude)
        : base(brand, model, year)
    {
        this.wingspan = wingspan;
        this.maxAltitude = maxAltitude;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Wingspan: {wingspan} meters\nMax Altitude: {maxAltitude} feet");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Mclaren", "750", 2023, 2, true),
            new Boat("Viking", "242X", 2022, "Titanium", 5),
            new Airplane("Ttchut Ttchut", "911", 2023, 40, 45000)
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"=== {vehicle.GetType().Name} Information ===");
            DisplayVehicleInfo(vehicle);
            Console.WriteLine();
        }
    }

    static void DisplayVehicleInfo(Vehicle vehicle)
    {
        vehicle.DisplayInfo();
        vehicle.StartEngine();
    }
}
