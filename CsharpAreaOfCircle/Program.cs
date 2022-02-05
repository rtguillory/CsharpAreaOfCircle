// See https://aka.ms/new-console-template for more information

//Operators Exercise 2 -- Area of Circle
//User input to get radius
Console.WriteLine("What is the radius of your circle?");

double radius;  //declared for use as out parameter

//handles string inputs--assigns 0 radius for string
//assigns input to radius if input is a number
var radiusInput = double.TryParse(Console.ReadLine(), out radius);  //handles string inputs--assigns 0 radius

Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");



static double AreaOfCircle(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
