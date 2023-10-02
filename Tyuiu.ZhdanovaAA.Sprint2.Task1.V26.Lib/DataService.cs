using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (c > d + 1000);
            res[1] = (a + 17 == b) & (c != d);
            res[2] = (a != b) || (c < d);
            res[3] = (a >= b) && (c <= d);
            res[4] = !(res[3]);
            res[5] = (a == b - 17) ^ (c > d);
            return res;
        }
    }
}
