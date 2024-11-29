using Bazele.Implementaions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Bazele
{
    struct Angajat
    {
        public string Name { get; set; }
        public double Sallary { get; set; }
    }
    static class Exercises
    {
        public static void LeapYear()
        {
            var an = int.Parse(Console.ReadLine());
            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

        public static void Triangle()
        {
            var laturaUnu = int.Parse(Console.ReadLine());
            var laturaDoi = int.Parse(Console.ReadLine());
            var laturaTrei = int.Parse(Console.ReadLine());

            if (laturaUnu == laturaDoi && laturaDoi == laturaTrei)
            {
                Console.WriteLine("Triunghiul este echilateral");
            }
            else if (laturaUnu == laturaDoi || laturaDoi == laturaTrei || laturaUnu == laturaTrei)
            {
                Console.WriteLine("Triunghiul este isoscel");
            }
            else
            {
                Console.WriteLine("Triunghiul este scalen");
            }
        }

        public static void Calculator()
        {
            Console.WriteLine("Introduceti primul numar:");
            int.TryParse(Console.ReadLine(), out int primulNumar);
            Console.WriteLine("Introduceti al doilea numar:");
            int.TryParse(Console.ReadLine(), out int alDoileaNumar);
            Console.WriteLine("Introduceti operatia:");
            var operatie = Console.ReadLine();
            switch (operatie)
            {
                case "+":
                    Console.WriteLine(primulNumar + alDoileaNumar);
                    break;
                case "-":
                    Console.WriteLine(primulNumar - alDoileaNumar);
                    break;
                case "*":
                    Console.WriteLine(primulNumar * alDoileaNumar);
                    break;
                case "/":
                    if (alDoileaNumar == 0)
                    {
                        Console.WriteLine("Nu se poate imparti la 0");
                        break;
                    }
                    Console.WriteLine(primulNumar / alDoileaNumar);
                    break;
                case "%":
                    Console.WriteLine(primulNumar % alDoileaNumar);
                    break;
                default:
                    Console.WriteLine("Operatie invalida");
                    break;
            }
        }

        public static void CautareSezon()
        {
            int.TryParse(Console.ReadLine(), out int luna);
            switch (luna)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Iarna");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Primavara");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Vara");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Toamna");
                    break;
                default:
                    Console.WriteLine("Luna invalida");
                    break;
            }
        }

        public static void TipulObiectului()
        {
            FindObject("sdklfjaskldjf");
            FindObject(121);
            FindObject('c');
            FindObject(123.23);
            FindObject(new { test = 2 });


            void FindObject(object obj)
            {
                bool foundType = true;
                switch (obj)
                {
                    case string str:
                        Console.WriteLine($"Tipul este string cu valoare: {str}");
                        break;
                    case int integer:
                        Console.WriteLine($"Tipul este int cu valoare: {integer}");
                        break;
                    case double dbl:
                        Console.WriteLine($"Tipul este double cu valoare: {dbl}");
                        break;
                    case bool boolean:
                        Console.WriteLine($"Tipul este bool cu valoare: {boolean}");
                        break;
                    default:
                        foundType = false;
                        break;
                }
                if (!foundType)
                {
                    Console.WriteLine($"Tipul necunoscut cu valoarea: {obj}");
                }
            }
        }

        public static void SuprafataAriei()
        {
            var firstArea = ("Circle", 5);
            var secondArea = ("Rectangle", 5d, 6d);
            var thirdArea = ("Square", 5d);
            var forthArea = ("Triangle", 5d, 6d, 6d);

            CalculateArea(firstArea);
            CalculateArea(secondArea);
            CalculateArea(thirdArea);
            CalculateArea(forthArea);
            CalculateArea(("test", 1));

            void CalculateArea(object obj)
            {
                switch (obj)
                {
                    case ("Circle", int radius):
                        Console.WriteLine($"Aria cercului este: {Math.PI * radius * radius}");
                        break;
                    case ("Rectangle", double width, double height):
                        Console.WriteLine($"Aria dreptunghiului este: {width * height}");
                        break;
                    case ("Square", double lat):
                        Console.WriteLine($"Aria patratului este: {lat * lat}");
                        break;
                    case ("Triangle", double lat1, double lat2, double lat3):
                        Console.WriteLine($"Aria triunghiului este: {lat1 * lat2 * lat3}");
                        break;
                    default:
                        Console.WriteLine("Forma necunoscuta");
                        break;
                }
            }
        }

        public static void SalariuCuBonus()
        {
            CalculateArea(new Angajat { Name = "Manager", Sallary = 1000 });
            CalculateArea(new Angajat { Name = "Vanzator", Sallary = 500 });
            CalculateArea(new Angajat { Name = "Dezvoltator", Sallary = 1200 });

            void CalculateArea(Angajat obj)
            {
                switch (obj)
                {
                    case { Name: "Manager" }:
                        Console.WriteLine($"Salariul cu bonus pentru Manager este: {obj.Sallary + 500}");
                        break;
                    case { Name: "Vanzator" }:
                        Console.WriteLine($"Salariul cu bonus pentru Vanzator este: {obj.Sallary + 300}");
                        break;
                    case { Name: "Dezvoltator" }:
                        Console.WriteLine($"Salariul cu bonus pentru Dezvoltator este: {obj.Sallary + 200}");
                        break;
                    default:
                        Console.WriteLine("Forma necunoscuta");
                        break;
                }
            }
        }

        public static void SumArray()
        {
            /*var arr = new int[5];
            double sum = 0;
            Console.WriteLine($"Citite {arr.Length} elemente de la tastatura");

            arr[0] = int.Parse( Console.ReadLine() );
            sum += arr[0];
            arr[1] = int.Parse( Console.ReadLine() );
            sum += arr[1];
            arr[2] = int.Parse( Console.ReadLine() );
            sum += arr[2];
            arr[3] = int.Parse( Console.ReadLine() );
            sum += arr[3];
            arr[4] = int.Parse( Console.ReadLine() );
            sum += arr[4];
            Console.WriteLine($"Suma medie este {sum / 5}");*/

            var input = ReadArrayElements();
            double[] arr = Array.ConvertAll(input.Split(' '), double.Parse);
            var med = arr.Sum() / arr.Length;
            Console.WriteLine($"Suma medie este {med}");
        }

        public static void InverArray()
        {
            var input = ReadArrayElements();
            var arr = Array.ConvertAll(input.Split(' ').Reverse().ToArray(), int.Parse);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void DistincElements()
        {
            var input = ReadArrayElements();
            var arr = input.Split(' ');
            var distinct = arr.Distinct();
            foreach (var i in distinct)
            {
                Console.WriteLine(i);
            }
        }

        public static void MaxMin()
        {
            var input = ReadArrayElements();
            var arr = input.Split(" ").ToArray(); //Array.ConvertAll(input.Split(" "), int.Parse);
            Console.WriteLine($"Elementul maxim este {arr.Max()}");
            Console.WriteLine($"Elementul min este {arr.Min()}");
        }

        public static void StackImplementation()
        {
            Stack<int> stack = new Stack<int>();
            var input = ReadArrayElements("Scriteti numere array-ului separte prin spatiu");
            var elements = Array.ConvertAll(input.Split(" "), int.Parse);
            foreach(var e in elements)
            {
                stack.Push(e);
            }

            Console.WriteLine($"Elementul de top este {stack.Pop()}");
            Console.WriteLine($"Urmatorul element este {stack.Peek()}");
        }

        public static void QueueImplementation()
        {
            Queue<int> queue = new Queue<int>();
            var input = ReadArrayElements("Scriteti numere array-ului separte prin spatiu");
            var elements = Array.ConvertAll(input.Split(" "), int.Parse);
            foreach (var e in elements)
            {
                queue.Enqueue(e);
            }

            Console.WriteLine($"Elementul de top este {queue.Dequeue()}");
            Console.WriteLine($"Urmatorul element este {queue.Peek()}");
        }

        public static void QueueImplementationWithStack()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }


        public static string ReadArrayElements(string text = null)
        {
            var textToDispaly = text ?? "Scriteti elementele array-ului separte prin spatiu";
            Console.WriteLine(textToDispaly);
            string input = Console.ReadLine();
            return input;
        }
    }
}
