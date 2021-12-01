namespace OOP2
{

    class Plane : Vehicle, IVehicle
    {
        public bool HasJetDrive { get; set; }

        public void Move()
        {
            Console.WriteLine("Die Räder sind in der Luft.");
        }

        public virtual void Landing()
        {
            Console.WriteLine("Landeanflug beginnt...");
        }
    }
}
