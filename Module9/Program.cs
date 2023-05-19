using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metod();
                throw new Exception("Исключение");
            }
            catch(Exception ex) when (ex.Message == "Исключение")
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) when (ex is ArgumentException)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) when (ex is FormatException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is IndexOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is OverflowException)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
        }
        static void Metod()
        {
        }
    }
}
