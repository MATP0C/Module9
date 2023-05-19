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
        static void Main(string[] args)
        {

            CalculateDelegate calcDelegate = Calculate;
            int result = calcDelegate.Invoke(100, 30);

            Console.WriteLine(result);
            Console.Read();

        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
