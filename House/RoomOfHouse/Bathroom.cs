using System;
using System.Reflection.PortableExecutable;

namespace House.RoomOfHouse
{
	public class Bathroom
	{
		public int CountBath { get; set; }

		public int CountBathRoom { get; set; }

		public int CountTableInBathroom { get; set; }

		public int CountChairInBathroom { get; set; }

		public int CountToilet { get; set; }

		public int CountWashingmachine { get; set; }

		public int CountShower { get; set; }

        public void ShowBathroom()
        {
            Console.WriteLine("Count of Bath: {0}", CountBath);
            Console.WriteLine("Count of Bathroom: {0}", CountBathRoom);
            Console.WriteLine("Count of Table: {0}", CountTableInBathroom);
            Console.WriteLine("Count of Chair: {0}", CountChairInBathroom);
            Console.WriteLine("Count of Toilet: {0}", CountToilet);
            Console.WriteLine("Count of Washing-machine: {0}", CountWashingmachine);
            Console.WriteLine("Count of Shower: {0}", CountShower);
        }

    }
}

