// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.FactoryPatterns;

namespace
ObjectOrientedDesign // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new FactoryPattern().mainEntry();
        }
    }
}
