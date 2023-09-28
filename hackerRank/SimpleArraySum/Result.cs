using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Result
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach (int i in ar)
            {
                sum += i;
            }
            return sum;
        }
    }
}
