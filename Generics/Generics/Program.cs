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

            #region GenericStack<T>
            //// IntStack intStack = new IntStack();
            //// intStack.Push()

            //GenericStack<string> stringStack = new GenericStack<string>();
            //stringStack.Push("abcde");

            //GenericStack<int> intStack = new GenericStack<int>();
            //intStack.Push(123); 
            #endregion

            #region Generische Methode mit Constraints
            //MachWas("Hallo Welt");
            //MachWas(12);
            //MachWas<double>(12.5); // Compiler leitet das vom Parameter ab
            //MachWas(new ObjectStack()); // Compiler leitet das vom Parameter ab 
            #endregion

            // Übung:
            // eigenes Dictionary implementieren
            // indexer + TAB + TAB
            // public TValue this[TKey index]
            // {
            //     get { return data[index]; }
            //     set { data[index] = value; }
            // }

            // Features:
            // .Add(key,value);
            // indexer
            // Constraint:
            // TKey muss ein wertetyp sein (where T: struct)
            // TValue muss ein referenztyp sein ( where T: class)

            GenericDictionary<double, string> meineWerte = new GenericDictionary<double, string>();

            meineWerte.Add(0.1, "Hallo");
            meineWerte.Add(0.5, "Welt");
            meineWerte.Add(1.0, "!");

            Console.WriteLine(meineWerte[0.5]);
            meineWerte[0.5] = "World";
            Console.WriteLine(meineWerte[0.5]);


            Console.WriteLine("---ENDE--");
            Console.ReadKey();
        }

        //public static void MachWas<T>(T input) where T : ObjectStack,IDisposable,IEnumerable
        //{
        //    input.
        //    Console.WriteLine(input);
        //}
    }
}
