using System.Drawing;

namespace Bazele.OOP
{
    public class Product
    {
        public string Name;

        public int Value;

        public Product(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product name: {Name}, value: {Value}");
        }
    }
}
