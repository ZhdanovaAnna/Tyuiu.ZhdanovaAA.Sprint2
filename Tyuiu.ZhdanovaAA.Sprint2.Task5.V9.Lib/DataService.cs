using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int day;
            string month = "";
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if ((n < 31) && (n > 0))
                        {
                            day = n + 1;
                        }
                        else
                        {
                            day = 1;
                            m += 1;
                        }
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if ((n < 30) && (n > 0))
                        {
                            day = n + 1;
                        }
                        else
                        {
                            day = 1;
                            m += 1;
                        }
                    }
                    break;
                case 2:
                    {
                        if ((n < 28) && (n > 0))
                        {
                            day = n + 1;
                        }
                        else
                        {
                            day = 1;
                            m += 1;
                        }
                    }
                    break;
                default:
                    {
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}\n День должен быть от 1 до 31. Значение {n}");
                    }
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
            if (day == 1)
            {
                m++;
            }
            return day.ToString() + " " + month;
        }
    }
}
