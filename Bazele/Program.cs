namespace Bazele
{
    internal class Program
    {
        enum ZileleSaptamanii
        {
            Luni = 5,
            Marti,
            Miercuri,
            Joi,
            Vineri,
            Sambata,
            Duminica
        }


        static void Main(string[] args)
        {
            /*Console.WriteLine("Scrieti prima data in format dd.MM.yyyy");
            var inputOne = Console.ReadLine();
            Console.WriteLine("Scrieti a doua data in format dd.MM.yyyy");
            var inputTwo = Console.ReadLine();
            var dateTimeOne = DateTime.ParseExact(inputOne, "dd.MM.yyyy", null);
            var dateTimeTwo = DateTime.ParseExact(inputTwo, "dd.MM.yyyy", null);*/
            /*var dateTimeOne = new DateTime(2021, 10, 1);
            var dateTimeTwo = new DateTime(2021, 10, 10);
            TimeSpan difference = dateTimeTwo - dateTimeOne;
            Console.WriteLine($"Diferenta dintre cele doua date este de {difference.Days} zile"); */

            /*var depozit = new Depozit(123, "Nicolae", 100, DateTime.UtcNow);
            depozit.Afisare();
            depozit.DepozitSum(100);
            depozit.Afisare();
            depozit.DepozitRetragere(50);
            depozit.Afisare();
            depozit.DepozitRetragere(200);*/

            /*int number = 1;
            IncrementRef(ref number);
            Console.WriteLine(number);
            Increment(number);
            Console.WriteLine(number);
            //IncrementOut(out number);
            Console.WriteLine(number);*/

            /*string text = "Ana are mere";
            text = null;*/
            /*Console.WriteLine(text ?? "Ana nu are mere");*/
            /*Console.WriteLine($"Lungimea text este: {text?.Length}");
            var textLength = text?.Length ?? 0;*/
            var t = (int)ZileleSaptamanii.Duminica;
            ZileleSaptamanii zi = (ZileleSaptamanii)Enum.Parse(typeof(ZileleSaptamanii), "Marti");
            Console.WriteLine(zi);
        }

        static void IncrementRef(ref int number)
        {
            number++;
            Console.WriteLine(number);
        }

        static void Increment(int number)
        {
            number++;
        }

        static void IncrementOut(out int number)
        {
            number = 20;
            Console.WriteLine(number);
        }
    }
}
