using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HomeWork5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Угадай число\"\n");
            int count;
            int numTarget;
            int numbAttempts = 0;
            string inputValues = "";

            while (true)
            {
                Console.WriteLine("Введите число - верхнюю границу диапазона (больше 0 и меньше 1000000) : ");
                string strCount = Console.ReadLine();
                if (int.TryParse(strCount, out count))
                {
                    if (count > 0 && count <= 1000000)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка ввода : {strCount}\nЧисло должно быть в диапазоне от 1 до 1000000 !\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода : {strCount}\n");
                }
            }

            Random rnd = new Random();
            numTarget = rnd.Next(1, count);
            Console.WriteLine($"Попробуйте угадать число в диапазоне от 1 до {count}\n");

            while (true)
            {
                Console.WriteLine("Введите число или нажмите <Enter> если надоест : ");
                string strNum = Console.ReadLine();
                if (int.TryParse(strNum, out int num))
                {
                    inputValues += strNum;
                    numbAttempts++;
                    if (num == numTarget)
                    {
                        Console.WriteLine($"Успех! Вы угадали число {numTarget}.");
                        Console.WriteLine($"Число попыток {numbAttempts}.\nБыли введены числа : {inputValues}\n");
                        break;
                    }
                    else
                    {
                        if (num < numTarget)
                        {
                            Console.WriteLine($"{num} меньше загаданного числа");
                        }
                        else
                        {
                            Console.WriteLine($"{num} больше загаданного числа");
                        }
                    }
                    inputValues += ", ";
                }
                else
                {
                    if (strNum == "")
                    {
                        Console.WriteLine($"Жаль, что не получилось угадать загаданное число {numTarget}.");
                        Console.WriteLine($"Число попыток {numbAttempts}.\nБыли введены числа : {inputValues}\n");
                        break;
                    }
                    Console.WriteLine($"Ошибка ввода : {strNum}");
                }
            }

            Console.WriteLine("Для завершения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
