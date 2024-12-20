namespace Bazele.OOP.ClassMembers
{
    public class Hotel
    {
        private static double TotalIncome = 0;
        private List<Room> rooms;

        public Hotel()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room roomToAdd)
        {
            Room existingRoom = null;
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == room.RoomNumber)
                {
                    existingRoom = room;
                    break;
                }
            }
            if (existingRoom != null)
            {
                Console.WriteLine("Room with number: {0} already exits!", existingRoom.RoomNumber);
            }else
            {
                rooms.Add(roomToAdd);
            }
        }

        public void ReserveRoom(int roomNumber)
        {
            int roomToReserveIndex = -1;

            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].RoomNumber == roomNumber)
                {
                    roomToReserveIndex = i;
                    break;
                }
            }

            if (roomToReserveIndex == -1)
            {
                Console.WriteLine("Room with number: {0} not found", roomNumber);
            }
            else 
            {
                if (!rooms[roomToReserveIndex].IsOccupied)
                {
                    TotalIncome += rooms[roomToReserveIndex].Price;
                }
                rooms[roomToReserveIndex].CheckIn();
            }
        }

        public void FreeRoom(int roomNumber)
        {
            int roomToReserveIndex = -1;

            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].RoomNumber == roomNumber)
                {
                    roomToReserveIndex = i;
                    break;
                }
            }

            if (roomToReserveIndex == -1)
            {
                Console.WriteLine("Room with number: {0} not found", roomNumber);
            }
            else
            {
                rooms[roomToReserveIndex].CheckOut();
            }
        }

        public void RemoveRoom(int roomNumber)
        {
            Room roomToRemove = null;
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    roomToRemove = room;
                    break;
                }
            }

            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
            }
            else
            {
                Console.WriteLine("Room with number: {0} not found", roomNumber);
            }
        }

        public List<Room> FindRoomByType(string type)
        {
            var roomsByType = new List<Room>();
            foreach (var room in rooms)
            {
                if (room.Type == type)
                {
                    roomsByType.Add(room);
                }
            }
            return roomsByType;
        }

        public List<Room> ListAvailableRooms()
        {
            var availableRooms = new List<Room>();
            foreach (var room in rooms)
            {
                if (!room.IsOccupied)
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }
    }
}
