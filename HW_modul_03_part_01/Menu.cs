using System;

namespace HW_modul_03_part_01
{
    internal class Menu
    {
        public void Menu1()
        {
            int num;
            Console.WriteLine(" Tема: Введение в классы.Обработка исключений.\n Модуль 3. Часть 1\n");
            Console.Write(" Задание 1 - нажмите 1\n Задание 2 - нажмите 2\n Задание 3 - нажмите 3\n Задание 4 - нажмите 4\n" +
                " Задание 5 - нажмите 5\n Задание 6 - нажмите 6\n\n Введите нужное значение: ");

            while (!int.TryParse(Console.ReadLine(), out num) || num == 0 || num > 6)
            {
                Console.Write("\n Введено неверное значение. Повторите попытку: ");
            }

            switch (num)
            {
                case 1:
                    Console.Clear();
                    Class1 class1 = new Class1();
                    break;
                case 2:
                    Console.Clear();
                    Class2 class2 = new Class2();
                    break;
                case 3:
                    Console.Clear();
                    Class3 class3 = new Class3();
                    break;
                case 4:
                    Console.Clear();
                    Class4 class4 = new Class4();
                    break;
                case 5:
                    Console.Clear();
                    Class5 class5 = new Class5();
                    break;
                case 6:
                    Console.Clear();
                    Class6 class6 = new Class6();
                    break;
            }

        }
        
    }
}
