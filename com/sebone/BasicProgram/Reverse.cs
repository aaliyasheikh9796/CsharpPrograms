using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public  class Reverse
    {
        public String GetReverseString(String s)
        {
            string s1 = "";
            char[]ch=s.ToCharArray();
            for (int i = ch.Length-1;i>=0; i--)
            {
                s1=s1+ch[i];
            }
            return s1;
        }

    }        
}
