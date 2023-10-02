using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programsss
{
    internal class Program
    {
        public static int a;
        static void Main()
        {
            int z, chisl;
            int num;
            

            do
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Угадай число.");
                Console.WriteLine("2. Таблица умножения.");
                Console.WriteLine("3. Вывод делителей числа.");
                Console.WriteLine("4. Закрыть программу.");

                 a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {

                    case 1:


                        Console.WriteLine("Угадайте ка число от 0 до 100 :)");
                            Random random = new Random();
                            chisl = random.Next(0, 100);
                        do
                        {
                            Console.WriteLine("Ваш вариантик:");
                            z = Convert.ToInt32(Console.ReadLine());
                            if (z < chisl)
                                Console.WriteLine("Загаданное число больше хехе :3");
                            if (z > chisl)
                                Console.WriteLine("Загаданное число меньше хехе :3");
                        } while (z != chisl);
                        Console.WriteLine("УРА! ПоБеДа!");
                        break;
                    case 2:
                        for (int i = 1; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.Write(i * j + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите число:");
                        num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                                Console.Write(i + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Такой программы нет :( Выберите программу из списка :3");
                        break;

                }

            } while (a != 4);
            Console.WriteLine("Пока :3");
        }
    }
}
