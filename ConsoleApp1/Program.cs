// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var a = new Exercise1().Run([2, 7, 11, 15], 9);
            var a = new Exercise20().Run("({{{{}}}))");
            Console.WriteLine(a.ToString());

        }
    }
}