//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1
{
    class Program
    {
        public const int n = 1000;
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++ )
            {
                if ((i % x) == 0 || (i % y) == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Result: {0}", sum);
            Console.ReadKey(true);
        }
    }
}
