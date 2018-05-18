using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");

            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // Swap 2 strings.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}", s1, s2);
            MyGenericMethods.Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0} {1}", s1, s2);
            Console.WriteLine();

            // Compiler will infer System.Boolean.
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);
            MyGenericMethods.Swap(ref b1, ref b2);
            Console.WriteLine("After swap: {0}, {1}", b1, b2);
            Console.WriteLine();

            // Must supply type parameter if
            // the method does not take params.
            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<string>();
            Console.WriteLine();

            // Compiler error! No params? Must supply placeholder!
            // DisplayBaseClass();

            List<int> nums = new List<int> { 10, 11, 12 };
            List<string> names = new List<string> { "johnny", "steve", "mike" };
            List<object> objs = new List<object> { "johnny", 24, true };

            PrintItemsInList<int>(nums);
            PrintItemsInList<string>(names);
            PrintItemsInList<object>(objs);

            Console.ReadLine();
        }

        public static void PrintItemsInList<T>(List<T> l)
        {
            Console.WriteLine("The list has members of {0}", typeof(T));
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, l[i]);
            }
            //foreach (T item in l)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine();
        }

        #region Non-Generic swap methods.
        // Swap two integers.
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Swap two Person objects.
        static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
