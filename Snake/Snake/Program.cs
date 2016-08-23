﻿using System;
using System.Collections.Generic;
using System.Threading;


namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			HorisontalLine upLine = new HorisontalLine(0, Console.BufferWidth - 1, 0, '+');
			upLine.Draw();

			HorisontalLine downLine = new HorisontalLine(0, Console.BufferWidth - 1, Console.BufferHeight - 1, '+');
			downLine.Draw();

			VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight - 1, 0, '+');
			leftLine.Draw();

			VerticalLine rightLine = new VerticalLine(0, Console.BufferHeight - 1, Console.BufferWidth - 1, '+');
			rightLine.Draw();

			Point p = new Point (1, 3, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.handleKey(key.Key);
				}
				Thread.Sleep(100);
				snake.Move();
			}

		}

	}
}
