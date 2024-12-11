using System;
using Tyuiu.IgnatovA.Lab2.Review.V9.Lib;

namespace Tyuiu.Ignatov.Lab2.TaskReview.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = " Выполнила: Игнатов А.В. | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.Write("Старт шага = ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец шага = ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            double[] results = ds.GetMassFunction(start, end);
            for (int x = 0; x < results.Length; x++)
            {
                int i = start + x;
                string fx = results[x].ToString();
                Console.WriteLine($"| {i,8} | {fx,8} |");
            }
            Console.ReadKey();
        }
    }
}