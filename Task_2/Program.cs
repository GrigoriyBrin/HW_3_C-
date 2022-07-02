// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки xa: ");
            double xa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки xb: ");
            double xb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки ya: ");
            double ya = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки yb: ");
            double yb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки za: ");
            double za = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите координаты точки zb: ");
            double zb = Convert.ToDouble(Console.ReadLine());
            
            double distance = Math.Round(Math.Sqrt((square(xb - xa)) + (square(yb - ya)) + (square(zb - za))), 2);
            Console.WriteLine(distance);
        }

        public static double square(double n)
        {
            n = n * n;
            return n;
        }
        
    }
}

