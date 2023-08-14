using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HomeWork2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            string inputCards = "";
            Console.WriteLine("Программа для подсчёта номиналов карт в игре \"21\"\n");
            while(true)
            {
                Console.WriteLine("Введите число Ваших карт (от 1 до 52) : ");
                string strCount = Console.ReadLine();
                if (int.TryParse(strCount, out count))
                {
                    if (count > 0 && count <= 52)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка ввода : {strCount}\nЧисло карт должно быть в диапазоне от 1 до 52 !\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода : {strCount}\nЧисло карт должно быть целым положительным чмслом !\n");
                }
            }

            for (int i = 0; i < count; i++)
            {
                while(true)
                {
                    Console.WriteLine($"Введите номинал {i + 1} карты : от 2 до 10 или J, Q, K, T");
                    string strCard = Console.ReadLine();
                    string card = strCard.ToUpper();
                    if (card == "J" || card == "Q" || card == "K" || card == "T")
                    {
                        sum += 10;
                        inputCards += card;
                        break;
                    }
                    else
                    {
                        if (int.TryParse(card, out int num))
                        {
                            if (num >= 2 && num <= 10)
                            {
                                sum += num;
                                inputCards += card;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Ошибка ввода : {strCard} - номинал карты должен быть от 2 до 10");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка ввода : {strCard}");
                        }
                    }
                }
                if (i + 1 < count)
                {
                    inputCards += ",";
                }
            }

            Console.WriteLine($"Номиналы {count} карт, введённых Вами : {inputCards}");
            Console.WriteLine($"Сумма карт равна {sum}");
            Console.WriteLine("\nДля завершения нажмите любую клавишу ...");
            Console.ReadKey();
        }
    }
}
