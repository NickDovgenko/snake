using System;
using System.Collections.Generic;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Point p1 = new Point (1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();


			HorisontalLine upLine = new HorisontalLine(0, Console.BufferWidth-1, 0, '+');
			upLine.Draw();

			HorisontalLine downLine = new HorisontalLine(0, Console.BufferWidth - 1, Console.BufferHeight-1, '+');
			downLine.Draw();

			VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight-1, 0, '+');
			leftLine.Draw();

			VerticalLine rightLine = new VerticalLine(0, Console.BufferHeight - 1, Console.BufferWidth - 1, '+');
			rightLine.Draw();

		}

	}
}
