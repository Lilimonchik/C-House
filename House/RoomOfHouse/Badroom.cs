using System;
namespace House
{
	public class Badroom
	{
		public int CountBad { get; set; }

		public Bad Bad { get; set; }

		public int CountChair { get; set; }

		public int CountTable { get; set; }


	}
	public class Bad
	{
		public int Size { get; set; }

		public int Height { get; set; }

	}
}

