using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class TwoSum
    {
        public Boolean Sum(int[] arr,int total) {
            Boolean flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j <arr.Length; j++)
                {
                    if (arr[i]+arr[j] == total)
                    {
                        flag = true;
                        break;
                    }
                } 
            }return flag;
            
        }
    }
}
