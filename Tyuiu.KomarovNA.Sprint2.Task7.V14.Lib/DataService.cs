using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovNA.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool insideCircle = x * x + y * y <= 1;

            // Проверка на нахождение выше y = x и ниже y = -x
            bool withinBounds = x >= 0 || y >= -x;

            // Проверка на нахождение в заштрихованной области
            if (insideCircle && withinBounds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
