using System;

namespace Laba1_Var4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину сторони рiвностороннього трикутника:");
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine();
            TETriangle triangle1 = new TETriangle(side);
            Console.WriteLine("Трикутник 1:");
            Console.WriteLine(triangle1);

            // Створення копії трикутника 1
            Console.WriteLine();
            TETriangle triangle2 = new TETriangle(triangle1);
            Console.WriteLine("Трикутник 2 (копiя трикутника 1):");
            Console.WriteLine(triangle2);

            Console.WriteLine();
            Console.WriteLine($"Площа трикутника 1: {triangle1.Area()}");

            // Порівняння трикутників
            Console.WriteLine();
            Console.WriteLine("Введiть довжину сторони нового рiвностороннього трикутника для порiвняння:");
            double side1 = double.Parse(Console.ReadLine());

            TETriangle triangleNEW = new TETriangle(side1);
            Console.WriteLine(triangleNEW);
            if (triangle1.Equals(triangleNEW))
            {
                Console.WriteLine("Трикутники 1 i NEW рiвнi.");
            }
            else
            {
                Console.WriteLine("Трикутники 1 i NEW не рiвнi.");
            }

            // Множення сторін трикутника
            Console.WriteLine();
            Console.WriteLine("Введiть число, на яке домножаємо трикутник:"); ;
            double multiplier = double.Parse(Console.ReadLine());

            TETriangle scaledTriangle = triangle1 * multiplier;
            Console.WriteLine($"Трикутник, збiльшений в {multiplier} рази:");
            Console.WriteLine(scaledTriangle);

            //Piramid
            Console.WriteLine();
            Console.WriteLine("Додайте висоту пiрамiди:");
            double height = double.Parse(Console.ReadLine());

            TEPiramid piramid = new TEPiramid(side, height);

            Console.WriteLine($"Об'єм пiрамiди: {piramid.Volume()}");
            Console.WriteLine($"Площа пiрамiди: {piramid.Area()}");
        }
    }
}
