using System;
using Lecture10;


Triangle triangle = new Triangle();
var triangleArea = triangle.TriangleSizes(5, 4);
var trianglePerimeter = triangle.TriangleSizes(5, 8, 4);
Console.WriteLine($"Triangle area: {triangleArea}");
Console.WriteLine($"Triangle perimeter: {trianglePerimeter}");
Multiply multiply = new Multiply();
double firstNumber = 5, secondNumber = 6;
int thirdNumber = 5, fourthNumber = 6;
Console.WriteLine($"Double: { multiply.MultiplyNumbers(firstNumber, secondNumber)}");
Console.WriteLine($"Int: {multiply.MultiplyNumbers(thirdNumber, fourthNumber)}");
Shape shape = new Shape();
shape.Rectangle(thirdNumber, fourthNumber);
triangle.thirdSide = 8;
triangle.Rectangle(thirdNumber, fourthNumber);

