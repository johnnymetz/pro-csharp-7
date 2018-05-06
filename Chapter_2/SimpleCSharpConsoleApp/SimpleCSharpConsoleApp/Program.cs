using System;
using System.Windows.Forms;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            System.Console.Title = "My Rocking App";
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for Enter key to be pressed.
            System.Console.ReadLine();
            MessageBox.Show("All done!");
        }
    }
}