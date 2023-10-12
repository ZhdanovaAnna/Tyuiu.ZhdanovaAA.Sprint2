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
            int day = 0;
            string days = "", month = "";
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
                            if (day < 10)
                            {
                                days = "0" + day.ToString();
                            }
                            else
                            {
                                days = day.ToString();
                            }
                        }
                        else
                        {
                            days = "01";
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
                            if (day < 10)
                            {
                                days = "0" + day.ToString();
                            }
                            else
                            {
                                days = day.ToString();
                            }
                        }
                        else
                        {
                            days = "01";
                            m += 1;
                        }
                    }
                    break;
                case 2:
                    {
                        if ((n < 28) && (n > 0))
                        {
                            day = n + 1;
                            if (day < 10)
                            {
                                days = "0" + day.ToString();
                            }
                            else
                            {
                                days = day.ToString();
                            }
                        }
                        else
                        {
                            days = "01";
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
                        month = "01";
                    }
                    break;
                case 2:
                    {
                        month = "02";
                    }
                    break;
                case 3:
                    {
                        month = "03";
                    }
                    break;
                case 4:
                    {
                        month = "04";
                    }
                    break;
                case 5:
                    {
                        month = "05";
                    }
                    break;
                case 6:
                    {
                        month = "06";
                    }
                    break;
                case 7:
                    {
                        month = "07";
                    }
                    break;
                case 8:
                    {
                        month = "08";
                    }
                    break;
                case 9:
                    {
                        month = "09";
                    }
                    break;
                case 10:
                    {
                        month = "10";
                    }
                    break;
                case 11:
                    {
                        month = "11";
                    }
                    break;
                case 12:
                    {
                        month = "12";
                    }
                    break;
            }
            if (day == 1)
            {
                m++;
            }
            return days + "." + month;
        }
    }
}
