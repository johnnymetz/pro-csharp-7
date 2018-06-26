using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreadedPrinting
{
    #region Printer helper class
    public class Printer
    {
        // Lock token.
        private object threadLock = new object();

        public void PrintNumbers()
        {
            lock (threadLock)
            {
                // Display Thread info.
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                  Thread.CurrentThread.Name);

                // Print out numbers.
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(100 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");

            Printer p = new Printer();

            // Make n threads that are all pointing to the same
            // method on the same object.
            int numberOfThreads = 10;
            Thread[] threads = new Thread[100];
            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                    {
                        Name = $"Worker thread #{i}"
                    };
            }

            // Now start each one.
            foreach (Thread t in threads)
                t.Start();
            Console.ReadLine();
        }
    }
}
