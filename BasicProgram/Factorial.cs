using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Factorial
    {
        public int IsFactorial(int n)
        {
            if (n >= 0)
            {
                int fact = 1;
                for(int i = 0; i>=1;i--)
                    fact=fact*i;
                Console.WriteLine(fact);
            }
            else
            {
                Console.WriteLine("not define");
            }
            return n;
        }
    }
}
