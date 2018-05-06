using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // Calls int version of Add()
            int ans1 = Add(10, 10);
            Console.WriteLine("{0} {1}", ans1, ans1.GetType().Name);

            // Calls long version of Add() (using the new digit separator)
            //Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
            double ans2 = Add(900_000_000_000, 900_000_000_000);
            Console.WriteLine("{0} {1}", ans2, ans2.GetType().Name);

            // Calls double version of Add()
            //Console.WriteLine(Add(4.3, 4.4));
            long ans3 = Add((long)4.3, (long)4.4);
            Console.WriteLine("{0} {1}", ans3, ans3.GetType().Name);

            Console.ReadLine();
        }

        #region Overloaded Add() methods
        // Overloaded Add() method.
        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        { return x + y; }

        static long Add(long x, long y)
        { return x + y; }
        #endregion
    }
}
