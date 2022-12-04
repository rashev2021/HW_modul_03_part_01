using System;


namespace HW_modul_03_part_01
{
    internal class Class5
    {
        public Class5()
        {
            Console.WriteLine("\n Задание 5.\n" +
                " Создайте класс «Журнал».\n" +
                " Необходимо хранить в полях класса: название журнала, год основания, описание журнала, контактный телефон,\n контактный e-mail.\n" +
                " Реализуйте методы класса для ввода данных, вывода данных.\n" +
                " Pеализуйте доступ к отдельным полям через методы класса.\n\n");

            Console.Write(" Введите название журнала: ");
            string name = Console.ReadLine();
            Console.Write(" Год основания: ");
            int year;

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("\n Введите цифры. Повторите попытку: ");
            }

            Console.Write(" Описание журнала: ");
            string discriptions = Console.ReadLine();
            Console.Write(" Контактный телефон: ");
            int tel;

            while (!int.TryParse(Console.ReadLine(), out tel))
            {
                Console.Write("\n Введите цифры. Повторите попытку: ");
            }

            Console.Write(" Контактный E-mail: ");
            string email = Console.ReadLine();

            Journal journal = new Journal(name, year, discriptions, tel, email);
            journal.Print();
           
        }
    }

    internal class Journal
    {
        string _name, _discriptions, _email;
        int _tel, _year;

        public Journal(string n, int y, string d, int t, string e)
        {
            _name = n;
            _year = y;
            _discriptions = d;
            _tel = t;
            _email = e;
        }

        public void Print()
        {
            Console.WriteLine("\n Показать название журнала       - нажмите 1");
            Console.WriteLine(" Показать год основания журнала  - нажмите 2");
            Console.WriteLine(" Показать описание журнала       - нажмите 3");
            Console.WriteLine(" Показать контактный телефон     - нажмите 4");
            Console.WriteLine(" Показать E_mail                 - нажмите 5");
            Console.WriteLine(" Показать ве пункты              - нажмите 6");

            Console.Write(" Введите нужное значение: ");

            int w;

            while (!int.TryParse(Console.ReadLine(), out w) || w == 0 || w > 6)
            {
                Console.Write("\n Введено неверное значение. Повторите попытку: ");
            }

            if (w == 1)
            {
                Console.Write($"\n Название журнала: {_name} ");
                MenuReturn();

            }
            if (w == 2)
            {
                Console.Write($"\n Год основания журнала: {_year} ");
                MenuReturn();
            }
            if (w == 3)
            {
                Console.Write($"\n Описание журнала: {_discriptions} ");
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
                Console.Write($"\n Называние журнала: {_name}\n Год основания журнала: {_year}\n Описание журнала: {_discriptions}\n " +
                    $"Контактный телефон: {_tel}\n Контактный E_mail: {_email}") ;
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
                Class5 class5 = new Class5();
            }
        }
    }
}
