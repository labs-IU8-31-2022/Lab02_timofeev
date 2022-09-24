Vehicle t1 = new Car(2, 4, 10000, 250, 2011);
Vehicle t2 = new Plane(78, 23, 250000000, 980, 1995, 11000, 385);
Ship t3 = new(34, 45, 400000, 25, 2003, 105, 7);
t1.Print();
t2.Print();
t3.Print();
Console.ReadLine();

class Vehicle
{
    private int _x;
    private int _y;
    private int _price;
    private int _speed;
    private int _year;
    
    protected Vehicle(int x, int y, int price, int speed, int year)
    {
        _x = x;
        _y = y;
        _price = price;
        _speed = speed;
        _year = year;
    } 

    virtual public void Print()
    {
        Console.WriteLine($"{_x}:{_y}");
        Console.WriteLine($"Price: {_price}$");
        Console.WriteLine($"Speed: {_speed} km/h");
        Console.WriteLine($"Year: {_year}");
    }
}

class Plane : Vehicle
{
    public static string Name = "Plane";
    private int _altitude;
    private int _passengers;

    public Plane(int x, int y, int price, int speed, int year, int altitude, int passengers) : base(x, y, price, speed,
        year)
    {
        _altitude = altitude;
        _passengers = passengers;
    }

    public override void Print()
    {
        Console.WriteLine($"{Name}");
        base.Print();
        Console.WriteLine($"Altitude: {_altitude}m");
        Console.WriteLine($"Count passengers: {_passengers}");
    }
}

class Car : Vehicle
{
    public static string Name = "Car";
    public Car(int x, int y, int price, int speed, int year) : base(x, y, price, speed, year) {}
    public override void Print()
    {
        Console.WriteLine(Name);
        base.Print();
    }
}

class Ship : Vehicle
{
    public static string Name = "Ship";
    private int _passengers;
    private int _port;
    
    public Ship(int x, int y, int price, int speed, int year, int passengers, int port) : base(x, y, price, speed, year)
    {
        _passengers = passengers;
        _port = port;
    }

    public override void Print()
    {
        Console.WriteLine(Name);
        base.Print();
        Console.WriteLine($"Count passengers: {_passengers}");
        Console.WriteLine($"Port: {_port}");
    }
}