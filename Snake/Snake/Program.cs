﻿using System;
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

			HorisontalLine line = new HorisontalLine(5, 10, 8, '+');
			line.Draw();

		}

	}
}
