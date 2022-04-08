using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class SumOfNumbers
    {
        public int sumOfNumber(int n)
        {
            int total=0;
            for (int i = 1; i <= n; i++)
            {
                 total += i;
            }
            return total;
        
        }
    }
}
