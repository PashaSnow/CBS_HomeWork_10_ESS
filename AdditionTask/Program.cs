using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask
{
    class MyClass<T> where T : new()     /* where T : new() - ограничение параметра типа Т, 
                                         * означает что в качестве типа Т можно поставить
                                         * только тот тип у которого есть открытый конструктор
                                         * по умолчанию */
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main()
        {
            int x = MyClass<int>.FactoryMethod();
            Console.WriteLine(x);
        }
    }
}
