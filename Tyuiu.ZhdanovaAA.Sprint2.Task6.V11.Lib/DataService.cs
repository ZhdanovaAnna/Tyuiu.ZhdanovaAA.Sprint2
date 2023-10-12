using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int year = g, day = 0;
            string days = "";
            string[] month = new string[12] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };


            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
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
                    } return days + "." + month[m-1] + "." + year.ToString();
                case 4:
                case 6:
                case 9:
                case 11:
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
                    } return days + "." + month[m - 1] + "." + year.ToString();
                case 2:
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
                    } return days + "." + month[m - 1] + "." + year.ToString();
                case 12:
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
                        m = 1;
                        year = g + 1;
                    } return days + "." + month[m - 1] + "." + year.ToString();
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}\n День должен быть от 1 до 31. Значение {n}");
            }
        }
    }
}
