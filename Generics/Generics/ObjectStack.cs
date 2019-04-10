using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ObjectStack
    {
        public ObjectStack()
        {
            index = 0;
            data = new object[4];
        }
        private object[] data;
        private int index;

        public void Push(object item)
        {
            if (index == data.Length)
            { // Vergrößern
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = item;
        }

        public object Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Stack ist leer");
            return data[--index];
        }

    }
}
