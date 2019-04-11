using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Erstellen von Tasks:
            //Task t1 = new Task(MachEtwas);
            //t1.Start();

            //Task.Factory.StartNew(MachEtwas2); // 4.0

            //Task.Run(new Action(MachEtwas3)); // 4.5 
            #endregion

            #region Tasks mit einem Ergebnis:
            //Task<string> t1 = Task.Factory.StartNew(GibDatum);
            //// Rückgabe:
            //Console.WriteLine($"Das Ergebnis ist {t1.Result}"); // Wenn das Ergebnis noch nicht da ist, wird auf das Ergebnis gewartet

            #endregion

            #region Auf einen Task warten
            //Task t1 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.Write('#');
            //        Thread.Sleep(10);
            //    }
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.Write('.');
            //        Thread.Sleep(50);
            //    }
            //});
            //Task t3 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.Write('-');
            //        Thread.Sleep(80);
            //    }
            //});

            ////t1.Wait();// Quasi "Thread.Join()"
            ////Task.WaitAll(t1, t2, t3);
            //Task.WaitAny(t1, t2, t3); 
            #endregion

            #region Tasks abbrechen

            //CancellationTokenSource cts = new CancellationTokenSource();

            //Task t1 = Task.Factory.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        if (cts.Token.IsCancellationRequested)
            //            break;
            //        Console.Write("#");
            //        Thread.Sleep(100);
            //    }
            //}); // ,cts.Token);  // => Das Token bewirkt als Parameter nur, dass noch NICHT gestartete Tasks abgebrochen werden können

            //Console.WriteLine("Kurz warten ...");
            //Thread.Sleep(5000);
            //Console.WriteLine("Task wird beendet ...");
            //cts.Cancel(); 
            #endregion

            #region Exceptions im Task
            //Task t1 = new Task(() =>
            //{
            //    Thread.Sleep(1000);
            //    throw new FormatException();
            //});
            //t1.Start();
            //Task t2 = Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    throw new DivideByZeroException();
            //});
            //Task t3 = Task.Factory.StartNew(() =>
            //{
            //    Thread.Sleep(5000);
            //    throw new StackOverflowException();
            //});
            //try
            //{
            //    // Task.WaitAny(t1, t2, t3); // KEINE Exception !!!
            //    Task.WaitAll(t1, t2, t3);
            //}
            //catch (AggregateException ex)
            //{
            //    foreach (Exception exception in ex.InnerExceptions)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }
            //}

            //Console.WriteLine($"Completed:{t1.IsCompleted}");
            //Console.WriteLine($"IsFaulted:{t1.IsFaulted}");
            //Console.WriteLine($"IsCanceled:{t1.IsCanceled}"); 
            #endregion


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static string GibDatum()
        {
            Thread.Sleep(3000);
            return DateTime.Now.ToLongTimeString();
        }

        private static void MachEtwas3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
            }
        }

        private static void MachEtwas2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
            }
        }

        private static void MachEtwas()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(".");
            }
        }
    }
}
