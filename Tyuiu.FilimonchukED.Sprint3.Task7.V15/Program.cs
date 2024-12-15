using Tyuiu.FilimonchukED.Sprint3.Task7.V15.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Филимончук Е. Д. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Итоговое решение прокта по спринту                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Филимончук Егор Дмитриевич | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* написать программу которая выводит таблицу значений функции             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int start = -5; int stop = 5;
            double[] valueArray;
            int len = ds.GetMassFunction(start, stop).Length;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(start, stop);
            Console.WriteLine("начало шага = " + start);
            Console.WriteLine("конец шага = " + stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0, 5:d} | {1, 6:f2} |", start, valueArray[i]);
                start++;
            }
        }
    }
}
