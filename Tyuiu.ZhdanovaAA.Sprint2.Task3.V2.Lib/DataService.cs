using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 0)
            {
                res = x - 12 * x + Math.Cos(x);
            }
            else
            {
                if (x == 0)
                {
                    res = x - (1 / x);
                }
                else
                {
                    if ((-6 < x) && (x < 0))
                    {
                        res = Math.Pow(x, 5) + 10 * x - (1 / (Math.Sqrt(x + 3)));
                    }
                    else
                    {
                        if (x < -6)
                        {
                            res = x + 10 * x - (1 / Math.Pow(x, 4));
                        }
                        else
                        {
                            res = 0;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
