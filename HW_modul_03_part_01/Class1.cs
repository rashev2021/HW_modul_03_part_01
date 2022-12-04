using System;

namespace HW_modul_03_part_01
{
    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine("\n Задание 1.\n" +
                " Напишите метод, который отображает квадрат из некоторого символа. \n" +
                " Метод принимает в качестве параметра: длину стороны квадрата, символ.\n\n");

            Console.Write(" Введите длину стороны квадрата: ");

            int longi;
            char symbol;

            while (!int.TryParse(Console.ReadLine(), out longi))
            {
                Console.Write("\n Введите целое число. Повторите попытку: ");
            }
            Console.Write(" Введите символ квадрата: ");

            while (!char.TryParse(Console.ReadLine(), out symbol))
            {
                Console.Write("\n Введите символ. Повторите попытку: ");
            }

            Quadrat(longi, symbol);

        } 

        void Quadrat(int l, char s) 
        {    
            char[,] array = new char[l,l];

            Console.WriteLine("\n");

            for (int i = 0; i < l; i++)
            {
                for(int j = 0; j < l; j++)
                {
                    array[i, j] = s;
                    Console.Write(" " + array[i,j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.Write(" Вернуться в меню введите 1: ");
            int exit;

            while (!int.TryParse(Console.ReadLine(), out exit) || exit != 1)
            {
                Console.Write("\n Введены неверные значения. Повторите попытку: ");
            }

            if(exit == 1)
            {
                Menu menu = new Menu();
                Console.Clear();
                menu.Menu1();
            }
        }
    }
}
