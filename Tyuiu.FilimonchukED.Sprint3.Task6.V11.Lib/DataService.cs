using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilimonchukED.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) // числа от 10 до 19
            {
                for (int j = 1; j <= i; j++) // число делителей
                {
                    if (i%j == 0 && j>10) count++;
                }
            }
            return count;
        }
    }
}
