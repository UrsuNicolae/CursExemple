namespace Bazele.OOP.GeneralPrinciples
{
    public class MathOperations
    {
        public int Add(int x, int y)
        {
            Console.WriteLine($"Add two integers {x + y}");
            return x + y;
        }

        public double Add(double x, double y)
        {
            Console.WriteLine($"Add two doubles {x + y}");
            return x + y;
        }

        public override string ToString()
        {
            return "MathOeparations class";
        }
    }
}
