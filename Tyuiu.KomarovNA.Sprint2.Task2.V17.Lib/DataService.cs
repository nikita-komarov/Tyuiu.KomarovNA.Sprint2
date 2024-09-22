using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovNA.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (3 <= x && x <= 12 && 5 <= y && y <= 7) 
            {
                return true;
            }
            return false;
        }
    }
}
