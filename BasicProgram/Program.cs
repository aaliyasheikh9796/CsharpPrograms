using BasicProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Program
    {
        public static void  Main(string[] args)
        {
            /* Console.WriteLine("PRESS 1 FOR PRIMENO.:");
             Console.WriteLine("PRESS 2 FOR ANAGRAM:");
             Console.WriteLine("PRESS 3 FOR FACTORIAL:");
             Console.WriteLine("PRESS 4 FOR SumNO.:");
             Console.WriteLine("PRESS 5 FOR REVERSE:");
             Console.WriteLine("PRESS 6 FOR TWO SUM:");*/



            int ch = 3; //int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        PrimeNo primeNo = new PrimeNo();
                        Console.WriteLine("------------------------PRIME CHECK-------------------------");
                        Console.WriteLine("Enter a no.");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (primeNo.IsPrime(n))
                            Console.WriteLine(n + "is prime");
                        else
                            Console.WriteLine(n + "not prime");





                        break;
                    }
                case 2:
                    {
                        string firstString, secondString;
                        Console.WriteLine("------------------------ANAGRAM CHECK-------------------------");
                        Console.WriteLine("Enter first String");
                        firstString = Console.ReadLine();
                        Console.WriteLine("Enter SecondString");
                        secondString = Console.ReadLine();
                        Anagram anagram = new Anagram();
                        //Check if words are anagram  
                        if (anagram.areAnagram(firstString, secondString) == true)
                        {
                            Console.WriteLine("Both string are anagram string.");
                        }
                        else
                        {
                            Console.WriteLine("Both string are not anagram string.");
                        }
                        Console.ReadLine();

                        break;
                    }
                case 3:
                    {
                        
                        Console.WriteLine("------------------------FACTORIAL CHECK-------------------------");
                        int n = 6;
                        Factorial factorial = new Factorial();
                        factorial.IsFactorial(n);
                        Console.WriteLine("---");

                        break;
                    }
                case 4:
                    {
                        int n = 10;
                        Console.WriteLine("------------------------SUM CHECK-------------------------");
                        SumOfNumbers sumOfNumbers = new SumOfNumbers();
                       
                        Console.WriteLine( sumOfNumbers.sumOfNumber(n));

                        break;
                    }
                case 5:
                    {
                        Reverse reverse = new Reverse();
                        Console.WriteLine("------------------------REVERSE CHECK-------------------------");
                        Console.WriteLine("Enter String for reverse = ");
                        String s=Console.ReadLine();    

                       
                        Console.WriteLine(reverse.GetReverseString(s));

                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("------------------------TWO SUM CHECK-------------------------");
                        TwoSum twoSum = new TwoSum();
                        int[] a =new int[8];
                        Console.WriteLine("Enter an array:");
                        for(int i = 0; i < 8; i++)
                        {
                            a[i] = Convert.ToInt16(Console.ReadLine());
                        }
                        Boolean flag = twoSum.Sum(a, 8);
                        if (flag)
                        {
                            Console.WriteLine("pair is present in the array");
                        }
                        else
                        {
                            Console.WriteLine("not present");
                        }
                        break;
                    }


            }
        }

      
    }
}

