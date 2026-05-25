//#define CHAR_CONTROL
//#define SHOOTER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
#if CHAR_CONTROL
			char key;
			do
			{
				key = Console.ReadKey(true).KeyChar;
				Console.WriteLine($"{(int)key}\t{key}");
				switch (key)
				{
					case 'w': Console.WriteLine("Вверх"); break;
					case 's': Console.WriteLine("Вниз"); break;
					case 'a': Console.WriteLine("Влево"); break;
					case 'd': Console.WriteLine("Вправо"); break;
				}
			} while (key != 27); 
#endif

#if SHOOTER
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				//Console.WriteLine($"{key}");
				switch (key)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:
						Console.WriteLine("Вверх"); break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:
						Console.WriteLine("Вниз"); break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:
						Console.WriteLine("Влево"); break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:
						Console.WriteLine("Вправо"); break;
					case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
					case ConsoleKey.Enter: Console.WriteLine("Огонь"); break;
				}
			} while (key != ConsoleKey.Escape); 
#endif

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			ConsoleKey key;
			int x=10;
			int y=10;
			const char symbol = '@';
			do
			{
				Console.Clear();
				Console.SetCursorPosition(x, y);
				Console.WriteLine(symbol);
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:		y--;	break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:		y++;	break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:		x--;	break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:		x++;	break;
				}
				if (x < 0) x = 0;
				if (y < 0) y = 0;
				if (x == 0 || y == 0) Console.Beep();
				//TODO: Задать размер консоли.
			} while (key != ConsoleKey.Escape);
		}
	}
}
