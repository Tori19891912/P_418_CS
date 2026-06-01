using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Fraction
	{
		public int Integer { get; set; }	//Автоствойство, описывающее целую часть
		public int Numerator { get; set; }  //Автоствойство, описывающее числитель
		int denominator;		//переменная, описывающая знаменатель
		public int Denominator	//Свойство, описывающее знаменатель
		{
			get => denominator; //Если метод можно реализовать одним выражением,
								//то его можно написать без фигурных скобок,
								//вместо этого после круглых скобок ставиться =>
			set => denominator = value == 0 ? 1 : value;
		}

		//					Constructors:
		public Fraction()
		{
			this.Integer = 0;
			this.Numerator = 0;
			this.Denominator = 1;
			Console.WriteLine($"DefaultConstructor:{this.GetHashCode()}");
		}
		public Fraction(int integer)
		{
			this.Integer = integer;
			this.Numerator = 0;
			this.Denominator = 1;
			Console.WriteLine($"Single-ArgumentConstructor:{GetHashCode()}");
		}
		public Fraction(int numerator, int denominator)
		{
			this.Integer = 0;
			this.Numerator = numerator;
			this.Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			this.Integer = integer;
			this.Numerator = numerator;
			this.Denominator = denominator;
			Console.WriteLine($"Constructor:\t{GetHashCode()}");
		}

		//					  Methods:
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
	}
}
