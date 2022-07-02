// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите 5-ти значное число");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString();
            int countSymbol = 5;

            if (b.Length == countSymbol)
            {
                int i = 0;
                int j = b.Length - 1;
                int count = b.Length / 2;
                string n = "Да";
                
                while (i < count) 
                {
                    if(b[i] != b[j])
                    {
                        n = "Нет";
                        break;
                    }
                    i++;
                    j--;

                }
                Console.WriteLine(n);
            }

        }

    }
}
