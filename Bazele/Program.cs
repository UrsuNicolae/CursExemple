using Bazele.HW;

namespace Bazele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indication data nasterii in format dd.MM.yyyy");
            var dataNasterii = DateTime.Parse(Console.ReadLine());
            var diff = DateTime.UtcNow - dataNasterii;
            Console.WriteLine($"Varsta: {diff.Days / 365}");
        }
    }
}
