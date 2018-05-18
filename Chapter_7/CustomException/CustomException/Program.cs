using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);

            string x = String.Empty;
            string y;
            string z = "";
            Console.WriteLine("here: {0}", x);
            Console.WriteLine("here: {0}", z);
            Console.WriteLine("here: {0}", x == z);

            //try
            //{
            //    // Trip exception.
            //    myCar.Accelerate(50);
            //}
            //catch (CarIsDeadException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ErrorTimeStamp);
            //    Console.WriteLine(e.CauseOfError);
            //}
            Console.ReadLine();
        }

    }
}
