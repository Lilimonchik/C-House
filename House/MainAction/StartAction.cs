using System;
using House.BoysHouse.HouseForAll;
using House.BoysHouse;

namespace House.MainAction
{
	public class StartAction
	{
		public void Start()
		{
			Console.WriteLine("Hello! You are welcome to the program that will help you to compare your Houses!");

			Console.WriteLine("There are 3 people who will play in this game: Andrew, Oleh, Anton");

			Console.WriteLine("Who will be the first?");
            int Count = 0;

			while (Count < 3)
			{
				string Firstplayer = Convert.ToString(Console.ReadLine());

				if (Firstplayer == "Andrew")
				{
					Count++;

					AddAndrewHouse AndrewHouse = new AddAndrewHouse();

					AndrewHouse.AddAndrew(Count);
				}
				else if(Firstplayer == "Oleh")
				{
					Count++;

					AddOlehHouse OlehHouse = new AddOlehHouse();

					OlehHouse.AddOleh(Count);

				}
				else if(Firstplayer == "Anton")
				{
					Count++;

					AddAntonHouse AntonHouse = new AddAntonHouse();

					AntonHouse.AddAnton(Count);
				}
				if (Count != 3)
				{
					Console.WriteLine("Who will be the next?");
				}
			}
		}
	}
}

