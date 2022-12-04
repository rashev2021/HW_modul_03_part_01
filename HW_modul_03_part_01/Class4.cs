using System;


namespace HW_modul_03_part_01
{
    internal class Class4
    {
        public Class4()
        {
            Console.WriteLine("\n Задание 4.\n" +
                " Создайте класс «Веб-сайт».\n" +
                " Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта.\n" +
                " Реализуйте методы класса для ввода данных, вывода данных.\n" +
                " Реализуйте доступ к отдельным полям через методы класса.\n\n");

            Console.Write(" Введите название сайта: ");
            string name = Console.ReadLine();
            Console.Write(" Введите путь к сайту: ");
            string patch = Console.ReadLine();
            Console.Write(" Введите описание сайта: ");
            string discriptions = Console.ReadLine();
            Console.Write(" Введите ip адрес сайта: ");
            int ip;

            while (!int.TryParse(Console.ReadLine(), out ip))
            {
                Console.Write("\n Введите цифры. Повторите попытку: ");
            }

            WebSuite webSuite = new WebSuite(name, patch, discriptions, ip);
            webSuite.Print();

        }
    }

    internal class WebSuite
    {
        string _name, _patch, _discriptions;
        int _ip;

      public WebSuite(string n, string p, string d, int i)
        {
            _name = n;
            _patch = p;
            _discriptions = d;
            _ip = i;
        }

        public void Print()
        {
            Console.WriteLine("\n Показать название сайта   - нажмите 1");
            Console.WriteLine(" Показать путь к сайту     - нажмите 2");
            Console.WriteLine(" Показать описание сайта   - нажмите 3");
            Console.WriteLine(" Показать ip адрес сайта   - нажмите 4");
            Console.WriteLine(" Показать все данные сайта - нажмите 5");
          
            Console.Write(" Введите нужное значение: ");

            int w;

            while (!int.TryParse(Console.ReadLine(), out w) || w == 0 || w > 5)
            {
                Console.Write("\n Введено неверное значение. Повторите попытку: ");
            }

           if(w == 1) 
            {
                Console.Write($"\n Название сайта: {_name} ");
                MenuReturn();
               
            }
            if (w == 2)
            {
                Console.Write($"\n Путь к сайту: {_patch} ");
                MenuReturn();
            }
            if (w == 3)
            {
                Console.Write($"\n Описание сайта: {_discriptions} ");
                MenuReturn();
            }
            if (w == 4)
            {
                Console.Write($"\n IP адрес сайта: {_ip} ");
                MenuReturn();
            }
            if (w == 5)
            {
                Console.Write($"\n Называние сайта: {_name}\n Путь к сайту: {_patch}\n Описание сайта: {_discriptions}\n IP адрес сайта: {_ip}");
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
                Class4 class4 = new Class4();
            }
        }
    }
}
