using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ Return Values *****\n");
            IEnumerable<string> subset = GetStringSubset();
            Console.WriteLine(subset.GetType());
            string[] subsetArr = GetStringSubsetAsArray();
            Console.WriteLine(subsetArr.GetType());
            List<string> subsetArr2 = GetStringSubsetAsList();
            Console.WriteLine(subsetArr2.GetType());
            Console.WriteLine();

            foreach (string item in subset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (string item in subsetArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        #region Linq query methods
        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};

            // Note subset is an IEnumerable<string>-compatible object.
            IEnumerable<string> theRedColors = from c in colors
                                               where c.Contains("Red")
                                               select c;

            return theRedColors;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};

            var theRedColors = from c in colors
                               where c.Contains("Red")
                               select c;

            // Map results into an array.
            return theRedColors.ToArray();
        }

        static List<string> GetStringSubsetAsList()
        {
            List<string> colors = new List<string> { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            List<string> theRedColors = (from c in colors
                where c.Contains("Red")
                select c).ToList<string>();

            // Map results into an array.
            return theRedColors;
        }
        #endregion
    }
}
