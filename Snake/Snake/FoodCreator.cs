using System;
namespace Snake
{
	class FoodCreator
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidht, int mapHeight, char sym)
		{
			this.mapWidht = Console.BufferWidth;
			this.mapHeight = Console.BufferHeight;
			this.sym = sym;
		}

		public Point CreateFood()
		{
			int x = random.Next(0, mapWidht);
			int y = random.Next(0, mapHeight);
			return new Point(x, y, sym);

		}

	}
}

