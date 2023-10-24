using System;

namespace Laba1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть сторони трикутника.");
            Console.Write("Сторона а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Сторона b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Сторона c: ");
            double c = double.Parse(Console.ReadLine());

            TTriangle triangle = new TTriangle(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Вiдповiдь:");
            Console.WriteLine($"Сторона 0: {triangle[0]}");
            Console.WriteLine($"Сторона 1: {triangle[1]}");
            Console.WriteLine($"Сторона 2: {triangle[2]}");
            Console.WriteLine($"Периметр: {triangle.Perimeter()}");
            Console.WriteLine($"Площа: {triangle.Area()}");
        }
    }
}
