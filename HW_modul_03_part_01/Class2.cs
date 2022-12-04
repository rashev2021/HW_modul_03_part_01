using System;
using System.Linq;

namespace HW_modul_03_part_01
{
    internal class Class2
    {
        public Class2() 
        {
            Console.WriteLine("\n Задание 2.\n" +
                " Напишите метод, который проверяет является ли переданное число «палиндромом». \n" +
                " Число передаётся в качестве параметра. \n" +
                " Если число палиндром нужно вернуть из метода true, иначе false.\n\n");

            Console.Write(" Введите число: ");
            int num;

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("\n Введите целое число. Повторите попытку: ");
            }

            Console.WriteLine(" " + Number(num));

            Console.Write("\n Вернуться в меню введите 1: ");
            int exit;

            while (!int.TryParse(Console.ReadLine(), out exit) || exit != 1)
            {
                Console.Write("\n Введены неверные значения. Повторите попытку: ");
            }

            if (exit == 1)
            {
                Menu menu = new Menu();
                Console.Clear();
                menu.Menu1();
            }

        }

        bool Number(int n)
        {
            string v = n.ToString();

            if (v.Reverse().SequenceEqual(v))
            {
                Console.WriteLine($"\n Число {n} - Палиндром!");
                return true;
            }
            else
            {
                Console.WriteLine($"\n Число {n} - Не палиндром!");
                return false;
            }        
        }
    }
}
