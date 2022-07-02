// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число больше 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            Console.Write($"{a} ->");

            while (a > 0 && count <= a)
            {
                PrintCube(count);
                count++;
            }
        }

        public static void PrintCube(int n)
        {
            Console.Write(" " + n * n * n);  
        }
        
    }
}


