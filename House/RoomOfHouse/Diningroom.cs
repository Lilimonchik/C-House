using System;
namespace House.RoomOfHouse
{
	public class Diningroom
	{
		public int CountDiningroom { get; set; }

		public int CountTableInDiningroom { get; set; }

		public int CountChairInDiningroom { get; set; }


        public void ShowBathroom()
        {
            Console.WriteLine("Count of room: {0}", CountDiningroom);
            Console.WriteLine("Count of Table: {0}", CountTableInDiningroom);
            Console.WriteLine("Count of Chair: {0}", CountChairInDiningroom);
        }

    }
}

