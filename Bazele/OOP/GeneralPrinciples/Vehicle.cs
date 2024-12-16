namespace Bazele.OOP.GeneralPrinciples
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public abstract void GetFuelConsumption();
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void GetFuelConsumption()
        {
            Console.WriteLine($"Fuel consumption is {NumberOfDoors * 0.2}");
        }
    }

    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public override void GetFuelConsumption()
        {
            Console.WriteLine($"Fuel consumption is {CargoCapacity * 0.25}");
        }
    }
}
