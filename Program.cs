using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        
        public static void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void differance(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static int product(int a, int b)
        {
            return a * b;
        }
        static void main()
        {
            int q = 30, t = 39;
            sum(q, t);
            differance(q, t);
            int result = product(q, t);
            Console.WriteLine(result);
        }
    }
}