//#define CONSOLE
#define STRING_OPERATIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
			Console.Title = "Introduction to .NET";
			Console.WriteLine("Hello .NET");
			Console.WriteLine();
			Console.CursorLeft = 32;
			Console.CursorTop = 16;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("Cursor position");
			Console.ResetColor();
			Console.Beep(37, 2000); 
#endif

#if STRING_OPERATIONS
			Console.WriteLine("Введите имя и фамилию:");
			string first_name = Console.ReadLine();
			string last_name = Console.ReadLine();
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк
			Console.WriteLine(string.Format("{0} {1} {2}", first_name, last_name, age));//Форматирование строк
			Console.WriteLine($"{first_name} {last_name} {age}"); 
#endif
		}
	}
}
