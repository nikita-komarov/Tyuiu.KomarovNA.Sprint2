using Tyuiu.KomarovNA.Sprint2.Task2.V17.Lib;
namespace Tyuiu.KomarovNA.Sprint2.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор if - полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
			Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры и *");
			Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
			Console.WriteLine("*и.                                                                       *");

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

            Console.WriteLine("Русский текст");
            // русский текст

            DataService ds = new DataService();

            var result = ds.CheckDotInShadedArea(1, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}