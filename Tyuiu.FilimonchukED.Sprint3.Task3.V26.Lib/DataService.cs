using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilimonchukED.Sprint3.Task3.V26.Lib
{
    public class DataService : ISprint3Task3V26
    {
        public int GetCharCount(string value, char item)
        {
            int k = 0;
            foreach (char chr in value)
            {
                if (chr == item) k++;
            }
            return k;
        }
    }
}
