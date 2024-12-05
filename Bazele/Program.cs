using Bazele.HW;

namespace Bazele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrieti elementele array-ului separate prin spatiu");
            var input = Console.ReadLine();
            var arr = input.Length > 0 ? Array.ConvertAll(input.Split(" "), int.Parse) : null;

            foreach (var item in Exercises.ReverseArray(arr))
            {
                Console.Write(item + " ");
            }
            /*while(Console.ReadLine() != "0")
            {
                Console.WriteLine("Scrieti numele si salariul angajatului");
                var angajat = new Angajat();
                angajat.Name = Console.ReadLine();
                angajat.Sallary = double.Parse(Console.ReadLine());
                Console.WriteLine(Exercises.SerializeAngajat(angajat));

            }*/
        }
    }
}
