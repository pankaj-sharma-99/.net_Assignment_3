using System;

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle();

        vehicle.Brand = "Toyota";
        vehicle.Model = "Fortuner";
        vehicle.Year = 2025;

        vehicle.DisplayDetails();
    }
}
