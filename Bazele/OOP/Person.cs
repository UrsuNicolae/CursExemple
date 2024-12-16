namespace Bazele.OOP
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = string.Empty;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Person name: {Name} age: {Age}");
        }
    }
}
