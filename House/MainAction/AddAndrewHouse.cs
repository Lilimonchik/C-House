using System;
using House;
using House.BoysHouse.HouseForAll;
using House.RoomOfHouse;

namespace House.MainAction
{
	public class AddAndrewHouse
	{
        public void AddAndrew(int Count)
        {
            Console.WriteLine("Okey, let's start with kitchen!");

            Console.Write("What count of table do you have?");

            int CountTable = Convert.ToInt32(Console.ReadLine());

            Console.Write("What count of chair do you have?");

            int CountChair = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What the size of table do you have?");

            int SizeOfTable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What the height of table do you have?");

            int HeightOfTable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of Refrigerator do you have?");

            int CountRefrigerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of plate do you have?");

            int CountPlate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of kettle do you have?");

            int CountKettle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of cup do you have?");

            int CountCup = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of kitchen do you have?");

            int CountKitchenRoom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well done! Now we will create your Bathroom!");

            Console.WriteLine("What count of bath do you have?");

            int CountBath = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of bathroom do you have?");

            int CountBathroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of table do you have?");

            int CountTableInBathroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of chair do you have?");

            int CountChairInBathroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of toilet do you have?");

            int CountToilet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of washing-machine do you have?");

            int CountWashingMachine = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of shower do you have?");

            int CountShower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well done! Now we will create your Diningroom!");

            Console.WriteLine("What count of diningroom do you have?");

            int CountDiningRoom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of table do you have?");

            int CountTableInDinigroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of chair do you have?");

            int CountChairInDinigroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well done! Now we will create your Livingroom!");

            Console.WriteLine("What count of bad do you have?");

            int CountBad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of television do you have?");

            int CountTelevision = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of livingroom do you have?");

            int CountLivingroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of table do you have?");

            int CountTableInLivingroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of chair do you have?");

            int CountChairInLivingRoom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of sofa do you have?");

            int CountSofa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well done! Now we will create your Badroom!");

            Console.WriteLine("What count of bad do you have?");

            int CountBadIntBadroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What the size of bad do you have?");

            int CountSizeOfBad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What the height of bad do you have?");

            int CountHeightOfBad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of chair do you have?");

            int CountChairInBadroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What count of table do you have?");

            int CountTableInBadroom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well done!");


            var AndrewHouse = new HouseForAll
            {
                Kitchen = new Kitchen
                {
                    CountChairInKitchen = CountChair,
                    CountKettle = CountKettle,
                    CountCup = CountCup,
                    CountKitchenRoom = CountKitchenRoom,
                    CountPlate = CountPlate,
                    CountRefrigerator = CountRefrigerator,
                    Table = new Table
                    {
                        Size = SizeOfTable,
                        Height = HeightOfTable
                    }
                },
                Bathroom = new Bathroom
                {
                    CountBath = CountBath,
                    CountBathRoom = CountBathroom,
                    CountShower = CountShower,
                    CountChairInBathroom = CountChairInBathroom,
                    CountTableInBathroom = CountTableInBathroom,
                    CountToilet = CountToilet,
                    CountWashingmachine = CountWashingMachine
                },
                Diningroom = new Diningroom
                {
                    CountChairInDiningroom = CountChairInDinigroom,
                    CountDiningroom = CountDiningRoom,
                    CountTableInDiningroom = CountTableInDinigroom
                },
                Livingroom = new Livingroom
                {
                    CountBad = CountBad,
                    CountChairInLuvingroom = CountChairInLivingRoom,
                    CountLivingRoom = CountLivingroom,
                    CountSofa = CountSofa,
                    CountTableInLivingroom = CountTableInLivingroom,
                    CountTelevision = CountTelevision
                },
                Badroom = new Badroom
                {
                    CountBad = CountBadIntBadroom,
                    CountChair = CountChairInBadroom,
                    CountTable = CountTableInBadroom,
                    Bad = new Bad
                    {
                        Size = CountSizeOfBad,
                        Height = CountHeightOfBad
                    }
                }
            };
            if (Count < 3)
            {
                Console.WriteLine("Let's create another house!");
            }
            else
            {
                Console.WriteLine("Well done!");
            }
        }
    public void Output()
        {
            Console.WriteLine("{0}",AndrewHouse);
        }
	}
}