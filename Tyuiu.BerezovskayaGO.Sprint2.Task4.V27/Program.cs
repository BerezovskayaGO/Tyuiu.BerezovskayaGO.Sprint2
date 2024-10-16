﻿using Tyuiu.BerezovskayaGO.Sprint2.Task4.V27.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                *");
            Console.WriteLine("* Тема: Тернарный оператор                                                                 *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #27                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием                *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменной                        *");
            Console.WriteLine("* X, Y с клавиатуры. Округлить полученное значение до трех знаков после запятой;           *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите значение переменной x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
