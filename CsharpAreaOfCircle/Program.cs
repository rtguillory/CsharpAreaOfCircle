// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is the radius of your circle?");
var radius = Console.ReadLine();
double rad = Convert.ToDouble(radius);
Console.WriteLine($"The area of a circle with radius {rad} is {AreaOfCircle(rad)}");



static double AreaOfCircle(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
