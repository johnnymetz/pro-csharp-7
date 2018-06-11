using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with reflection & dynamic keyword *****\n");
            Assembly assembly = Assembly.Load("MathLibrary");
            Type math = assembly.GetType("MathLibrary.SimpleMath");
            AddWithReflection(math);
            AddWithDynamic(math);
            Console.ReadLine();
        }

        #region Add with reflection
        private static void AddWithReflection(Type type)
        {
            try
            {
                // Create a SimpleMath on the fly.
                object obj = Activator.CreateInstance(type);

                // Get info for Add.
                MethodInfo mi = type.GetMethod("Add");

                // Invoke method (with parameters).
                object[] args = { 10, 70 };
                Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Add with dynamic
        private static void AddWithDynamic(Type type)
        {
            try
            {
                // Create a SimpleMath on the fly.
                dynamic obj = Activator.CreateInstance(type);
                Console.WriteLine("Result is: {0}", obj.Add(10, 70));
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
