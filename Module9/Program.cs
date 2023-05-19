using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    class Program
    {
        delegate int CalculateDelegate(int a, int b);
        delegate int SumDelegate(int c, int d);
        static void Main(string[] args)
        {

            CalculateDelegate calcDelegate = Calculate;
            int result1 = calcDelegate.Invoke(100, 30);
            SumDelegate sumDelegate = Sum;
            int result2 = sumDelegate(200, 60);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.Read();

        }
        static int Sum(int c, int d)
        {
            return c + d;
        }
        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
