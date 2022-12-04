using System;


namespace HW_modul_03_part_01
{
    internal class Class6
    {
        public Class6()
        {
            Console.WriteLine("\n Задание 6.\n" +
                " Создайте класс «Магазин».\n" +
                " Необходимо хранить в полях класса: название магазина, адрес, описание профиля магазина, контактный телефон,\n контактный e-mail.\n" +
                " Реализуйте методы класса для ввода данных, вывода данных\n" +
                " Pеализуйте доступ к отдельным полям через методы класса.\n\n");

            Console.Write(" Введите название магазина: ");
            string name = Console.ReadLine();
            Console.Write(" Введите адрес магазина: ");
            string addres = Console.ReadLine();
            Console.Write(" Введите описание профиля магазина: ");
            string discriptions = Console.ReadLine();
            Console.Write(" Контактный телефон: ");
            int tel;

            while (!int.TryParse(Console.ReadLine(), out tel))
            {
                Console.Write("\n Введите цифры. Повторите попытку: ");
            }

            Console.Write(" Контактный E-mail: ");
            string email = Console.ReadLine();

            Shop shop = new Shop(name, addres, discriptions, tel, email);
            shop.Print();

        }
    }

    internal class Shop
    {
        string _name, _addres, _discriptions, _email;
        int _tel;

        public Shop(string name, string addres, string discriptions, int tel, string email)
        {
            _name = name;
            _addres = addres;
            _discriptions = discriptions;
            _email = email;
            _tel = tel;
        }

        public void Print()
        {
            Console.WriteLine("\n Показать название магазина         - нажмите 1");
            Console.WriteLine(" Показать адрес магазина            - нажмите 2");
            Console.WriteLine(" Показать описание профиля магазина - нажмите 3");
            Console.WriteLine(" Показать контактный телефон        - нажмите 4");
            Console.WriteLine(" Показать E_mail                    - нажмите 5");
            Console.WriteLine(" Показать вcе пункты                - нажмите 6");

            Console.Write(" Введите нужное значение: ");

            int w;

            while (!int.TryParse(Console.ReadLine(), out w) || w == 0 || w > 6)
            {
                Console.Write("\n Введено неверное значение. Повторите попытку: ");
            }

            if (w == 1)
            {
                Console.Write($"\n Название магазина: {_name} ");
                MenuReturn();

            }
            if (w == 2)
            {
                Console.Write($"\n Адрес магазина: {_addres} ");
                MenuReturn();
            }
            if (w == 3)
            {
                Console.Write($"\n Описание профиля магазина: {_discriptions} ");
                MenuReturn();
            }
            if (w == 4)
            {
                Console.Write($"\n Контактный телефон: {_tel} ");
                MenuReturn();
            }
            if (w == 5)
            {
                Console.Write($"\n Контактный E_mail: {_email} ");
                MenuReturn();
            }
            if (w == 6)
            {
                Console.Write($"\n Название магазина: {_name}\n Адрес магазина: {_addres}\n Описание профиля магазина: {_discriptions}\n " +
                    $"Контактный телефон: {_tel}\n Контактный E_mail: {_email}");
                MenuReturn();
            }

        }

        public void MenuReturn()
        {
            Console.WriteLine("\n\n Вернуться в меню - нажмите 0");
            Console.WriteLine(" Повторить        - нажмите 1");
            Console.Write("\n Введите нужное значение: ");

            int ex;

            while (!int.TryParse(Console.ReadLine(), out ex) || ex > 1)
            {
                Console.Write("\n Введено неверное значение. Повторите попытку: ");
            }

            if (ex == 0)
            {
                Menu menu = new Menu();
                Console.Clear();
                menu.Menu1();
            }
            else
            {
                Console.Clear();
                Class6 class6 = new Class6();
            }
        }
    }
}
