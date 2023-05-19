using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module9
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberRaeder numberRaeder = new NumberRaeder();
            numberRaeder.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberRaeder.Read();
                    throw new Exception("Собственное исключение");
                }
                catch (Exception ex) when (ex.Message == "Собственное исключение")
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введино некоректное значение");
                }
                catch (Exception ex) when (ex is ArgumentException)
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
                    Console.WriteLine("Повторите попытку снова");
                }
            }
        }
        static void ShowNumber(int number)
        {
            switch(number)
            {
                case 1:
                    {
                        Console.WriteLine("Введино значение: 1"); 
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Введино значение: 2");
                    }
                    break;
            }
        }
    }
    class NumberRaeder 
    {
        public delegate void NumberEnteredDelegat(int number);
        public event NumberEnteredDelegat NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine("Введите значение: 1 или 2");
            Console.WriteLine("1 (сортировка А-Я), 2 (сортировка Я-А)");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);

            Console.WriteLine("Список имён");
            string[] strArray = new string[] { "Таня", "Аня", "Коля", "Оля", "Дима" };
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            if (number == 1)
            {
                Console.WriteLine("Имена от (А-Я)");
                Array.Sort(strArray);
                foreach (string str in strArray)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Имена от (Я-А)");
                Array.Sort(strArray);
                Array.Reverse(strArray);
                foreach (string str in strArray)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    } 
}
