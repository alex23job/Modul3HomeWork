using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HomeWork4ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа поиска наименьшего элемента в последовательности\n");
            int count;
            int myMin = int.MaxValue;
            string inputValues = "";

            while (true)
            {
                Console.WriteLine("Введите число - длину последовательности (больше 0 и меньше 100) : ");
                string strCount = Console.ReadLine();
                if (int.TryParse(strCount, out count))
                {
                    if (count > 0 && count <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка ввода : {strCount}\nЧисло должно быть в диапазоне от 1 до 100 !\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода : {strCount}\n");
                }
            }


            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Введите {i + 1} натуральное число");
                    string strNum = Console.ReadLine();
                    if (int.TryParse(strNum, out int num))
                    {
                        if (num < myMin)
                        {
                            myMin = num;
                        }
                        inputValues += strNum;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка ввода : {strNum}");
                    }
                }
                if (i + 1 < count)
                {
                    inputValues += ", ";
                }
            }

            Console.WriteLine($"Значения введённых Вами {count} чисел  : {inputValues}");
            Console.WriteLine($"Минимальное число равно {myMin}");
            Console.WriteLine("\nДля завершения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
