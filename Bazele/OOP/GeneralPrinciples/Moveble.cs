namespace Bazele.OOP.GeneralPrinciples
{
    public interface IMovable
    {
        void Move();
    }
    public class MovableCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class MovableBicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
