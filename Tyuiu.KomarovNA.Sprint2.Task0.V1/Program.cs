using Tyuiu.KomarovNA.Sprint2.Task0.V1.Lib;

namespace Tyuiu.KomarovNA.Sprint2.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
            Console.WriteLine("*торая вернет логическую последовательность(массив): (True, False, True, F*");
            Console.WriteLine("*False, True, False), при x = 233, y = 122                                *");
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

            int x = 233;
            int y = 122;
            bool[] result = ds.GetCompareOperations(x, y);
            foreach(bool el in result) {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}