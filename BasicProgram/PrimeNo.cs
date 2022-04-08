using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{ 
   public class PrimeNo
    {
        
        public Boolean IsPrime(int n)
        {
            int i;
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                return false;
            }
            return true;

        }

    }
   

}
