using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class IntStack
    {
        public IntStack()
        {
            index = 0;
            data = new int[4];
        }
        private int[] data;
        private int index;

        public void Push(int item)
        {
            if (index == data.Length)
            { // Vergrößern
                Array.Resize(ref data, data.Length * 2);
            }
            data[index++] = item;
        }

        public int Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Stack ist leer");
            return data[--index];
        }
    }
}
