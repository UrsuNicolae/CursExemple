using Bazele.OOP.GeneralPrinciples;

namespace Bazele
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var complexNumber1 = new ComplexNumber(12, 1);
            var complexNumber2 = new ComplexNumber(12, 1);
            var complexNumber3 = complexNumber1 + complexNumber2;
            Console.WriteLine(complexNumber1);
            Console.WriteLine(complexNumber2);
            Console.WriteLine(complexNumber3);
        }
    }
}
