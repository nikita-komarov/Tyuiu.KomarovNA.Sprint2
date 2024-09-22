using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovNA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {

            // Определяем день недели
            string dayOfWeek = (k % 7) switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                0 => "воскресенье",
                _ => throw new NotImplementedException()
            };

            return dayOfWeek;
        }
    }
}
