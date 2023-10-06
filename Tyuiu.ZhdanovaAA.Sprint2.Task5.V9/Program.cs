using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание: 5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Примечание: нельзя вводить 31 декабря");
            Console.WriteLine();
           
            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string month = "";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            if (((m == 12) && (n == 31)) || ((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                Console.WriteLine("Введенно недопустимое значение!");
            }

            else
            {
                int day = ds.FindDateOfNextDay(m, n);
                if (day == 1)
                {
                    m++;
                }

                switch (m)
                {
                    case 1:
                        {
                            month = "Января";
                        }
                        break;
                    case 2:
                        {
                            month = "Февраля";
                        }
                        break;
                    case 3:
                        {
                            month = "Марта";
                        }
                        break;
                    case 4:
                        {
                            month = "Апреля";
                        }
                        break;
                    case 5:
                        {
                            month = "Мая";
                        }
                        break;
                    case 6:
                        {
                            month = "Июня";
                        }
                        break;
                    case 7:
                        {
                            month = "Июля";
                        }
                        break;
                    case 8:
                        {
                            month = "Августа";
                        }
                        break;
                    case 9:
                        {
                            month = "Сентября";
                        }
                        break;
                    case 10:
                        {
                            month = "Октября";
                        }
                        break;
                    case 11:
                        {
                            month = "Ноября";
                        }
                        break;
                    case 12:
                        {
                            month = "Декабря";
                        }
                        break;
                }
                Console.WriteLine($"Дата следующего дня: {day.ToString() + " " + month}");
            }
            Console.ReadKey();
        }
    }
}
