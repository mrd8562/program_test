using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvitan
{
    class Full
    {
        static Full[] a = new Full[500];
        static int n;

        private int num { get; set; }
        private string date { get; set; }
        private float sum { get; set; }

        internal void add()
        {
            Console.WriteLine();
            Console.Write("Введите кол-во записей: ");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Full();
                Console.Write("Номер квитанции: ");
                a[i].num = int.Parse(Console.ReadLine());
                Console.Write("Дата: ");
                a[i].date = Console.ReadLine();
                Console.Write("Стоимость: ");
                a[i].sum = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine();
            }
        }
        internal void print()
        {
            Console.WriteLine();
            Console.WriteLine("Список стран:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i}. Номер квитанции: {a[i].num}, Дата: {a[i].date}, Стоимость: {a[i].sum}.");
            }
            Console.WriteLine();
        }
    }
}

