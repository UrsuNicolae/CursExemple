namespace Bazele.OOP.ClassMembers
{
    public class Room
    {
        private int InternNr;
        public int RoomNumber { get; init; }

        public string Type { get; init; }

        public double Price { get; init; }

        public bool IsOccupied { get; private set; }

        public Room(int number, string type, double price)
        {
            RoomNumber = number;
            Type = type;
            Price = price;
        }

        public void CheckIn()
        {
            if (IsOccupied)
            {
                Console.WriteLine($"Room: {RoomNumber} is already occupied");
                return;
            }
            IsOccupied = true;
        }
        public void CheckOut()
        {
            if (!IsOccupied)
            {
                Console.WriteLine($"Room: {RoomNumber} is not occupied");
                return;
            }
            IsOccupied = false; 
        }
    }
}
