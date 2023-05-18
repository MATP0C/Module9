using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try запущен.");
                throw new ArgumentOutOfRangeException("Сообщение об ошибке");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Блок catch запущен.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally запущен.");
            }
            Console.ReadKey();
        }
    }
}
