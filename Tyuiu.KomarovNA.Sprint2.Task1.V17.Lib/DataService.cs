using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovNA.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return [a>b, c<b, d>=a, a>b, d>b, a<b];
        }
    }
}