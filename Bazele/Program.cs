using Bazele.OOP.ClassMembers;

namespace Bazele
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();
            hotel.AddRoom(new Room(200, "simple", 50));
            hotel.FindRoomByType("simple");
            hotel.ReserveRoom(200);
        }
    }
}
