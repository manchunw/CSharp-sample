using System;

namespace ConsoleApplication
{
    public class Program
    {
        public enum CarType {
            Toyota = 1,
            Honda = 2,
            Ford = 3
        }
        public static void Main(string[] args)
        {
            string productName = "TV";
            int productYear = 2012;
            double productPrice = 279.99;
            CarType myCarType = CarType.Toyota;
            Console.WriteLine(productName + " in " + productYear + ": " + productPrice);
            Console.WriteLine("Hello World!");
        }
    }
}
