namespace Bazele.OOP.GeneralPrinciples
{
    public abstract class Shape
    {
        public abstract void CalcuateArea();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void CalcuateArea()
        {
            Console.WriteLine($"Circle area is {Math.PI * Radius * Radius}");
        }
    }

    public class Square : Shape
    {
        public int Lat { get; set; }

        public override void CalcuateArea()
        {
            Console.WriteLine($"Square area is {Lat * Lat}");

        }
    }
}
