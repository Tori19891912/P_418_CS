using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static string delimiter = "\n-----------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine(true);
			Console.WriteLine(false);
			Console.WriteLine(sizeof(bool));
			Console.WriteLine(true.GetType());
			Console.WriteLine(delimiter);

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("char");
			Console.ResetColor();
			Console.WriteLine(sizeof(char));//Unicode
			Console.WriteLine(delimiter);

			//byte  sbyte - Signed byte
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("byte");
			Console.ResetColor();
			Console.WriteLine("Size: " + sizeof(byte) + " byte");
			Console.WriteLine($"Range:{byte.MinValue} ... {byte.MaxValue}");
			Console.WriteLine(((byte)0).GetType());

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("sbyte");
			Console.ResetColor();
			Console.WriteLine($"Size: {sizeof(sbyte)} byte");
			Console.WriteLine($"Range:{sbyte.MinValue} ... {sbyte.MaxValue}");
			Console.WriteLine(((sbyte)0).GetType());
			Console.WriteLine(delimiter);

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("short");
			Console.ResetColor();
			Console.WriteLine($"Size: {sizeof(short)}");
			Console.WriteLine($"Range:{short.MinValue} ... {short.MaxValue}");
			Console.WriteLine(((short)0).GetType());

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("ushort");
			Console.ResetColor();
			Console.WriteLine($"Size: {sizeof(ushort)}");
			Console.WriteLine($"Range:{ushort.MinValue} ... {ushort.MaxValue}");
			Console.WriteLine(((ushort)0).GetType());


		}
	}
}
