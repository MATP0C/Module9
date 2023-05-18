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
                throw new RankException("Сообщение об ошибке");
            }
            catch(RankException ex)
            {
                Console.WriteLine("Блок catch запущен.");
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("Блок finally запущен.");
            }
            Console.ReadKey();
        }
    }
}
