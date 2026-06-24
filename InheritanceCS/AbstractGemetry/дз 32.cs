using System;

public abstract class Shape
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public void PrintRadius()
    {
        Console.WriteLine("Радиус окружности: " + radius);
    }
}

public class Square : Shape, IRotatable
{
    private double side;
    public Square(double side)
    {
        this.side = side;
    }
    public override double CalculatePerimeter()
    {
        return 4 * side;
    }
    public override double CalculateArea()
    {
        return Math.Pow(side, 2);
    }
    public void PrintSide()
    {
        Console.WriteLine("Сторона квадрата: " + side);
    }
    public void Rotate()
    {
        Console.WriteLine("Квадрат повернут");
    }
}

public class Triangle : Shape, IRotatable
{
    private double side;
    public Triangle(double side)
    {
        this.side = side;
    }
    public override double CalculatePerimeter()
    {
        return 3 * side;
    }
    public override double CalculateArea()
    {
        return Math.Pow(side, 2) * Math.Sqrt(3) / 4;
    }
    public void Rotate()
    {
        Console.WriteLine("Треугольник повернут");
    }
}

public interface IRotatable
{
    void Rotate();
}

class Program
{
    static void Main(string[] args)
    {
        Circle = new Circle(5);
        Square = new Square(4);
        Triangle = new Triangle(3);

        circle.PrintRadius();
        Console.WriteLine("Длина окружности: " + circle.CalculatePerimeter());
        Console.WriteLine("Площадь круга: " + circle.CalculateArea());

        square.PrintSide();
        Console.WriteLine("Периметр квадрата: " + square.CalculatePerimeter());
        Console.WriteLine("Площадь квадрата: " + square.CalculateArea());

        triangle.Rotate();
        Console.WriteLine("Периметр треугольника: " + triangle.CalculatePerimeter());
        Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());

        IRotatable[] rotatables = new IRotatable[] { square, triangle };
        foreach (IRotatable rotatable in rotatables)
        {
            rotatable.Rotate();
        }
    }
}