using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //konto = new Bankkonto(1000);

            //for (int i = 0; i < 100; i++)
            //    ThreadPool.QueueUserWorkItem(ZufälligesUpdate);

            for (int i = 0; i < 100; i++)
            {
                ThreadPool.QueueUserWorkItem(MachWas);
            }


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
        private static Semaphore semaphore = new Semaphore(3, 3);
        private static object lockObject = new object();
        private static int zähler = 0;
        private static void MachWas(object state)
        {
            semaphore.WaitOne();
            zähler++;
            Console.WriteLine(zähler);
            zähler--;
            semaphore.Release();
        }


        private static Bankkonto konto;
        private static Random r = new Random();

        public static void ZufälligesUpdate(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                if (r.Next(1, 100) < 50)
                    konto.Einzahlen(r.Next(0, 1000));
                else
                    konto.Abheben(r.Next(0, 1000));
            }
        }
    }
}
