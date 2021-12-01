namespace OOP2
{
    abstract class Vehicle
    {
        public int DoorCount { get; set; }
        public float Speed { get; set; }
        public float Accleration { get; set; }
        public float BreakSpeed { get; set; }

        public void LogInformation()
        {
            Console.WriteLine($"Das Fahrzeug hat eine max Geschwindigkeit von: {Speed} km/h");
        }
    }
}
