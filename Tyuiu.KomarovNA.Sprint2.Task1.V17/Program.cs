using System;
using Tyuiu.KomarovNA.Sprint2.Task1.V17.Lib;

namespace Tyuiu.KomarovNA.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Логические операции                                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность можно чередовать, но использовать один раз в выражении) и логи*");
            Console.WriteLine("*ических операций (|, &, ||, &&, !, ^, последовательность операций не долж*");
            Console.WriteLine("*жна нарушаться), а также арифметических выражений, которая вернет логичес*");
            Console.WriteLine("*скую последовательность(массив): (True, False, True, True, True, False), *");
            Console.WriteLine("* при a = 135, b = 123, c = 455, d = 321                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int a, b, c, d;
            a = 135;
            b = 123;
            c = 455;
            d = 321;

            bool[] result = ds.GetLogicOperations(a, b, c, d);
            foreach (bool el in result)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}