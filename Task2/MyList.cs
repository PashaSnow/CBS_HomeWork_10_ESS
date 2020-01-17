using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyList<T> : IAmList<T>
    {
        /// <summary>
        /// Даний предикат будем поміщати в якості умови в методи: Find, FindAll, RemoveAll, Exist
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public delegate bool MyPredicate<in T>(T val);
        #region Constuctors
        public MyList() : this(0)
        { }
        public MyList(int count)
        {
            // масив не має бути менше 0
            if (count < 0)
            {
                this.array = new T[0];
            }
            this.array = new T[count];
        }
        #endregion

        #region Filds and Properties
        private T[] array;

        public T this[int index]
        {
            get { return array[index]; }
        }

        /// <summary>
        /// Повертає розмір списку
        /// </summary>
        public int Count { get { return this.array.Length; } }
        #endregion

        #region Basic methods

        /// <summary>
        /// Добавити ряд елементів
        /// </summary>
        /// <param name="item">масив або ряд елементів</param>
        public void AddRange(params T[] item)
        {
            T[] buf = new T[item.Length + this.array.Length]; // можливо потрібно додати одиницю
            if (array.Length == 0 && buf.Length != 0)
                for (int i = 0; i < buf.Length; i++)
                {
                    if (i >= this.array.Length)
                    {
                        buf[i] = item[i - array.Length];
                    }
                    else // попрацювати з індексом
                        buf[i] = array[i];
                }
            else
                buf[0] = item[0];
            this.array = buf;
        }
        /// <summary>
        /// Добавити один елемент
        /// </summary>
        /// <param name="item">Додати в список</param>
        public void Add(T item)
        {
            AddRange(item);
        }

        /// <summary>
        /// Очистити список
        /// </summary>
        public void Clear()
        {
            this.array = Array.Empty<T>();
        }

        /// <summary>
        /// Перевірити чи містить список ітем (х)
        /// </summary>
        /// <param name="item">Знайти в списку</param>
        /// <returns>True - в разі успіху</returns>
        public bool Conteins(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (Equals((object)item, (object)array[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Повертає даний масив елементів <Т>
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            return this.array;
        }

        /// <summary>
        /// Перевірка чи відповідає хоч один елемент списку истиності певному твердженню
        /// </summary>
        /// <param name="condition">Предикат</param>
        /// <returns></returns>
        public bool Exist(MyPredicate<T> condition)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (condition.Invoke(array[i]))
                    return true;
            }
            return false;
        }

        #endregion
    }
}
