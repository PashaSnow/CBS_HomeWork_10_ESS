using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IAmList<T>
    {
        void Add(T x);
        T this[int index] { get; }
        void Clear();
        bool Conteins(T item);
    }
}
