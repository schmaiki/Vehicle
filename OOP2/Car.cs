namespace OOP2
{

    class Car : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Vier Räder haben bodenkontakt.");
        }
    }
}
