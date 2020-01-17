using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Program
    {

        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] newArray = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                newArray[i] = list[i];
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            MyList<string> x = new MyList<string>();
            x.AddRange("Я", "бы", "сказал", "ничего", "не", "обычного");
            var y = x.GetArray();

            Console.WriteLine("Вывод");
            //for (int i = 0; i < y.Length; i++)
            //{
            //    Console.Write($"{y[i]} ");
            //}

            foreach (var item in y)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Type.GetType(y.ToString()).Name);
            Console.WriteLine();
        }
    }
}