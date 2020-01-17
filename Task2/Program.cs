using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>. 
 *Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
 *индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  */
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> x = new MyList<double>(0);
            Console.WriteLine("Count " + x.Count);
            x.Add(5.81d);
            Console.WriteLine("x {0:#.#}", x[0]);
            x.AddRange(16, 26, 17, 27);

            for (int i = 0; i < x.Count; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Exist {0}", x.Exist(i => i > 3));
            Console.WriteLine("Containse {0}", x.Conteins(5.81));
            double[] y = x.ToArray();

            Console.Write("Return array {0} ", Type.GetType(y.ToString()).Name);
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + " ");
            }

            x.Clear();
            if (x.Count != 0)
                for (int i = 0; i < x.Count; i++)
                {
                    Console.Write(x[i] + " ");
                }
            else
                Console.WriteLine("\nIt`s clear. Count = {0}", x.Count);
        }
    }
}
