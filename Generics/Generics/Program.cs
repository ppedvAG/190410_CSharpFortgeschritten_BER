using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack<T> - LIFO
            //Stack<int> meinStack = new Stack<int>();

            //meinStack.Push(12);
            //meinStack.Push(7);
            //meinStack.Push(3);
            //meinStack.Push(99);

            //Console.WriteLine(meinStack.Pop());
            //Console.WriteLine(meinStack.Pop());
            //Console.WriteLine(meinStack.Pop());
            //Console.WriteLine(meinStack.Pop()); 
            #endregion

            #region ObjectStack
            //ObjectStack os = new ObjectStack();

            //os.Push(12);
            //os.Push(7);
            //os.Push(new ObjectStack());
            //os.Push(3);
            //os.Push("Hallo Welt");

            //Console.WriteLine(os.Pop());
            //Console.WriteLine(os.Pop());
            //Console.WriteLine(os.Pop());
            //Console.WriteLine(os.Pop());
            //Console.WriteLine(os.Pop());

            //// Console.WriteLine(os.Pop()); 
            #endregion

            // IntStack intStack = new IntStack();
            // intStack.Push()

            GenericStack<string> stringStack = new GenericStack<string>();
            stringStack.Push("abcde");

            GenericStack<int> intStack = new GenericStack<int>();
            intStack.Push(123);

            Console.WriteLine("---ENDE--");
            Console.ReadKey();
        }
    }
}
