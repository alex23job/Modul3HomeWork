using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HomeWork3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки простого числа\n");

            bool isSimple = true;
            int num = 0;
            while(true)
            {
                Console.WriteLine("Введите целое положительное число");
                string inputNum = Console.ReadLine();
                if (int.TryParse(inputNum, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода : {inputNum}.");
                }
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            Console.WriteLine($"Число {num} {(isSimple ? "простое" : "не может считаться простым")}.");
            Console.WriteLine("\nДля завершения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
