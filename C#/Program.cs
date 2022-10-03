using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");
            List<int> elements = Singleton<int>(0);
            Console.WriteLine(elements[0]);
            Console.WriteLine("Null");
            bool b = Null<int>(elements);
            Console.WriteLine(b);
            Console.WriteLine("snoc");
            Snoc<int>(elements, 10);
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("length");
            int k = Length(elements);
            Console.WriteLine(k);
        }
        public static List<T> Singleton<T>(T element)
        {
            return new List<T> { element };
        }
        public static bool Null<T>(List<T> elements)
            {
            int k = 0;
            foreach (T element in elements)
            {
                k++;
            }
            return k == 0 ? true : false;
            }
        public static void Snoc<T>(List<T> elements, T element) => elements.Add(element);

        public static int Length<T>(List<T> elements)
        {
            int k = 0;
            foreach (var item in elements)
            {
                k++;
            }
            return k;
        }
    }
}
