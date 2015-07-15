using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите выражение");
            Console.WriteLine();
            Console.WriteLine();
            string s = Console.ReadLine();
            s = s.Remove(s.Length - 1);
            string[] h = s.Split(new char[]{'+','-'});
            for (int i = 0; i < h.Length; i++)
                sum += Convert.ToInt32(h[i]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Переписываем выражение с учётом его решения");
            Console.WriteLine();
            Console.Write("{0}={1}", s, sum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ответ: {0}", sum);
            Console.ReadKey();
        }
    }
}
