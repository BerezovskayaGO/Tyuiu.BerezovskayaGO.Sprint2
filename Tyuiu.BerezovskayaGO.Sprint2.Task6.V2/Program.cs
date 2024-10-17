using Tyuiu.BerezovskayaGO.Sprint2.Task6.V2.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                *");
            Console.WriteLine("* Тема: Получение результата из switch                                                     *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #2                                                                               *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch         *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                     *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите порядковый номер месяца: ");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введено неверное значение!"; 
            }
            else
            {
                res = "Пора года в этот месяц: " + ds.FindMonthSeason(numMouth);
            }
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
