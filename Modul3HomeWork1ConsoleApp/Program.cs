using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HomeWork1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число : ");
                string strNum = Console.ReadLine();
                if (int.TryParse(strNum, out int num))
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Число {num} это чётное целое число");
                    }
                    else
                    {
                        Console.WriteLine($"Число {num} это нечётное целое число");
                    }
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода : {strNum} - не целое число");
                }
            }
        }
    }
}
