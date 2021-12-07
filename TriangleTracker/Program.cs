using System;
using TriangleTracker;

public class Program
{
  public static void Main() {

    int side1, side2, side3;

    Console.WriteLine("Triangle Tracker");
    Console.WriteLine("===================");
    Console.WriteLine("Enter first side of a triangle:");
    side1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second side of a triangle:");
    side2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter third side of a triangle:");
    side3 = int.Parse(Console.ReadLine());

    Triangle triangle1 = new Triangle(side1, side2, side3);
    Console.WriteLine(triangle1.CheckTriangle());
  }
}