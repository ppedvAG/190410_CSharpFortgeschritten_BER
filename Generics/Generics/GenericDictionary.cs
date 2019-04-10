using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericDictionary<TKey,TValue> where TKey : struct
                                         where TValue : class
    {
        public GenericDictionary() : this(4){}
        public GenericDictionary(int capacity)
        {
            keys = new TKey[capacity];
            values = new TValue[capacity];
            index = 0;
        }
        private int index;
        private TKey[] keys;
        private TValue[] values;

        public void Add(TKey newKey, TValue newValue)
        {
            if (keys.Contains(newKey))
                throw new ArgumentException("Key ist bereits vorhanden");

            if(index == keys.Length)
            {
                Array.Resize(ref keys, keys.Length * 2);
                Array.Resize(ref values, values.Length * 2);
            }

            keys[index] = newKey;
            values[index] = newValue;

            index++;
        }

        public TValue this[TKey key]
        {
            get
            {
                if (! keys.Contains(key))
                    throw new ArgumentException("Key ist nicht vorhanden");

                int index = Array.IndexOf(keys, key); // zb. 5
                return values[index]; // Wenn der Key bei 5 ist, ist die Value ebenfalls bei 5
            }
            set
            {
                if (!keys.Contains(key))
                    throw new ArgumentException("Key ist nicht vorhanden");

                int index = Array.IndexOf(keys, key); // zb. 5
                values[index] = value;
            }
        }
    }
}
