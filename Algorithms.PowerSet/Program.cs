using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.PowerSet
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        string PrintAll(string str, int i)
        {
            string res = "";
            var n = str.Length;

            if(n == i) 
            {
                Console.WriteLine(res);
                return res;
            }

            res = PrintAll(str, i + 1);

            return res;
        }
    }
}
