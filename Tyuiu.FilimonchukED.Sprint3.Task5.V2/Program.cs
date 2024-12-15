using Tyuiu.FilimonchukED.Sprint3.Task5.V2.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Филимончук Е. Д. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Филимончук Егор Дмитриевич | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для нахождения ответа по формуле                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5; int strt1 = 1; int strt2 = 1; int stp1 = 3; int stp2 = 12;
            Console.WriteLine("*  начало суммы = " + strt1 + "                                           *");
            Console.WriteLine("*  конец суммы = " + stp1 + "                                             *");
            Console.WriteLine("*  начало суммы сумм = " + strt2 + "                                      *");
            Console.WriteLine("*  конец суммы сумм = " + stp2 + "                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ = " + ds.GetSumSumSeries(x, strt1, strt2, stp1, stp2));
        }
    }
}
