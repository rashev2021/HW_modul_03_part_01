using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_03_part_01
{
    internal class Class3
    {
        public Class3()
        {

            Console.WriteLine("\n Задание 3.\n" +
                " Напишите метод, фильтрующий массив на основании переданных параметров. \n" +
                " Метод принимает параметры: оригинальный_массив, массив с данными для фильтрации.\n" +
                " Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации\n\n");

            Console.Write(" Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            Console.Write(" Введите набор символов и цифр: ");

            string[] arr = new string[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                Console.WriteLine(" " + arr[i] + " ");
            }

            Console.Write(" Введите фильтрующий массив. ");
            Console.Write(" Введите количество строк, которые хотите ввести: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите набор символов и цифр: ");

            string[] arr1 = new string[n1];

            for (int i = 0; i < n; i++)
            {
                arr1[i] = Console.ReadLine();
                Console.WriteLine(" " + arr1[i] + " ");
            }

            Console.WriteLine(" " + Mass(arr, arr1));
            Console.ReadLine();

        } 

        string Mass(string[] arr, string[] arr1)
        {
            return arr[4];
        }
    }
}
