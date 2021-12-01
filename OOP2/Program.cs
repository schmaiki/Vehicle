using System.Text;

namespace OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car()
        {
            Accleration = 90,
            BreakSpeed = 50,
            DoorCount = 5,
            Speed = 200

        };

        Plane plane = new Plane()
        {
            Accleration = 200,
            BreakSpeed = 190,
            DoorCount = 4,
            Speed = 990,
            HasJetDrive = true
        };

        Motorcycle motorcycle = new Motorcycle()
        {
            Accleration = 50,
            BreakSpeed = 25,
            Speed = 250
        };

        Helicopter helicopter = new Helicopter()
        {
            Accleration = 140,
            BreakSpeed = 190,
            DoorCount = 4,
            Speed = 320,
            HasJetDrive = false
        };

        vehicles.Add(car);
        vehicles.Add(plane);
        vehicles.Add(motorcycle);
        vehicles.Add(helicopter);

        Console.Write("Was für Fahrzeug möchten Sie? : ");
        string? inputUser = Console.ReadLine();

        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle.GetType().Name == inputUser)
            {
                Console.WriteLine("Fahrzeug gefunden : " + inputUser);
                vehicle.LogInformation();
                if (inputUser == nameof(Car))
                {
                    Car myCar = vehicle as Car;
                    myCar.Move();
                }
                else if (inputUser == nameof(Plane))
                {
                    Plane myPlane = vehicle as Plane;
                    myPlane.Move();
                    myPlane.Landing();
                }
                else if (inputUser == nameof(Motorcycle))
                {
                    Motorcycle myMotorcycle = vehicle as Motorcycle;
                    myMotorcycle.Move();
                }
                else if (inputUser == nameof(Helicopter))
                {
                    Helicopter helicopter1 = vehicle as Helicopter;
                    helicopter1.Move();
                    helicopter1.Landing();
                }
                else
                {
                    Console.WriteLine("Fahrzeug nicht gefunden !");
                }
                break;
            }
        }
    }
}