namespace Bazele.OOP
{
    public class Outer
    {
        public class Inner
        {
            public void ShowMessage()
            {
                Console.WriteLine("Message from inner class");
            }
        }

        public void UseInner()
        {
            var inn = new Inner();
            inn.ShowMessage();
        }
    }
}
