using System;
namespace House.RoomOfHouse
{
	public class Kitchen
	{
		public Table Table  { get; set; }

		public int CountChairInKitchen { get; set; }

		public int CountRefrigerator { get; set; }

		public int CountPlate { get; set; }

		public int CountKettle { get; set; }

		public int CountCup { get; set; }

		public int CountKitchenRoom { get; set; }


		public void ShowKitchen()
		{
			Console.WriteLine("Count of Table: {0}",Table.Size);
            Console.WriteLine("Count of Chair: {0}", CountChairInKitchen);
            Console.WriteLine("Count of Refrigerator: {0}", CountRefrigerator);
            Console.WriteLine("Count of Plate: {0}", CountPlate);
            Console.WriteLine("Count of Kettle: {0}", CountKettle);
            Console.WriteLine("Count of Cup: {0}", CountCup);
            Console.WriteLine("Count of Kitchenroom: {0}", CountKitchenRoom);
        }
	}
	public class Table
	{
		public int Size { get; set; }

		public int Height { get; set; }
	}
}

