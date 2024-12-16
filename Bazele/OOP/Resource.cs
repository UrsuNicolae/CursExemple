namespace Bazele.OOP
{
    public class Resource
    {
        private string filePath;

        private bool used;

        public Resource(string path)
        {
            filePath = path;
            Console.WriteLine($"Resource is allocated for file: {path}");
        }

        public void UseResource()
        {
            if(!used)
            {
                Console.WriteLine("Using resource");
                used = true;
            }
            else
            {
                Console.WriteLine("Already used");
            }
        }

        ~Resource()
        {
            Console.WriteLine("Memoria sa eliberat");
        }
    }
}
