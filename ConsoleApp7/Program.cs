using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите язык (C#, VB или C++)"); // просьба пользователя ввести название языка программирования
            string myLanguage = Console.ReadLine(); // считывание локальной переменной myLanguage, которой присвоен строковый тип string

            sw1(myLanguage);

            Console.ReadLine(); //чтение строк
        }

        // Данный метод выводит выбор пользователя
        static void sw1(string s)
        {
            switch (s) //Оператор switch выбирает список операторов, который нужно выполнить, на основе соответствия шаблона выражению.
            {
                case "C#": // объявление языка C# для последующего вывода на экран, причем этот язык должен быть выбран непосредственно пользователем
                    Console.WriteLine("Вы выбрали язык C#"); // вывод на экран строки "..."
                    break;
                case "VB": // объявление языка VB для последующего вывода на экран, причем этот язык должен быть выбран непосредственно пользователем
                    Console.WriteLine("Вы выбрали язык Visual Basic"); // вывод на экран строки "..."
                    break;
                case "C++": // объявление языка C++ для последующего вывода на экран, причем этот язык должен быть выбран непосредственно пользователем
                    Console.WriteLine("Вы выбрали язык С++"); // вывод на экран строки "..."
                    break;
                default:
                    Console.WriteLine("Такой язык я не знаю"); // вывод на экран строки "..."
                    break;
            }
        }
    }
}