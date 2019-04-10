using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericStack<T>
    {
        public GenericStack()
        {
            index = 0;
            data = new T[4];
        }
        private T[] data;
        private int index;

        public void Push(T item)
        {
            if (index == data.Length)
            { // Vergrößern
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = item;
        }

        public T Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Stack ist leer");
            return data[--index];
        }

    }
}
