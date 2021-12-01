namespace OOP2
{
    class Motorcycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Zwei Räder haben bodenkontakt.");
        }
    }
}
