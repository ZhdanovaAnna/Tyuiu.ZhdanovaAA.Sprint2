using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint2.Task2.V9.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание: 2                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений, которая запрашивает целые     *");
            Console.WriteLine("* значения с клавиатуры и вычисляет находится ли точка с координатами X,Y *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x, y;
            Console.WriteLine("Введите значение координаты X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine($"Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка не находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
