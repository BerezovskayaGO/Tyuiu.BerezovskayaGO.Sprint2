using Tyuiu.BerezovskayaGO.Sprint2.Task1.V14.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Березовская Г. О. | АСОиУБ-24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* спринт #2                                                                                *");
            Console.WriteLine("* Тема : Логические операции                                                               *");
            Console.WriteLine("* Задание #1                                                                               *");
            Console.WriteLine("* Вариант #14                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУб-24-1                                     *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в                          *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность                 *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,                        *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                                    *");
            Console.WriteLine("* (False, True, True, True, True, False),                                                  *");
            Console.WriteLine("* при a = 185, b = 216, c = 174, d = 917                                                   *");
            Console.WriteLine("********************************************************************************************");

            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* a = 185, b = 216, c = 174, d = 917                                                       *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
