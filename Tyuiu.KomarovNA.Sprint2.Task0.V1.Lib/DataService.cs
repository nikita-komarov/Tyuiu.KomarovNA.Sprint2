using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovNA.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return [x>y, x<y, x>y, x<y, x>y, x<y];
        }
    }
}