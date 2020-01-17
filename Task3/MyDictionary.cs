 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] val;

        public MyDictionary()
        { }
        public MyDictionary(TKey key, TValue val)
        {
            //this.key = new TKey[key];
            //this.val = new TValue[val];
        }
    }
}
