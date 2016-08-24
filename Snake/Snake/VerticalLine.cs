using System;
using System.Collections.Generic;
namespace Snake
{
	class VerticalLine : Figure
	{
		
		public VerticalLine(int yDown, int yUp, int x, char sym)
		{
			pList = new List<Point>();
			for (int y = yDown; y <= yUp; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}

		}

		public override void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			base.Draw();
		}

	}

}

