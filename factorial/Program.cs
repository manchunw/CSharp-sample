using System;

public class Functions{
    public static long Factorial(int n) {
        if ((n < 0) || (n > 20)) return -1;
        long tmpSum = 1;
        for (int i = 1; i <= n; ++i) {
            tmpSum *= i;
        }
        return tmpSum;
    }
}

namespace ConsoleApplication
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0){
                Console.WriteLine("Please input an argument.");
                Console.WriteLine("Usage: Factorial <num>");
                return 1;
            }
            
            int num;
            bool test = int.TryParse(args[0], out num);
            if (test == false) {
                Console.WriteLine("Please enter a numeric argument.");
                Console.WriteLine("Usage: Factorial <num>");
                return 1;
            }

            // Calculate factorial.
            long result = Functions.Factorial(num);

            // Print result.
            if (result == -1)
                System.Console.WriteLine("Input must be >= 0 and <= 20.");
            else
                System.Console.WriteLine("The Factorial of {0} is {1}.", num, result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            return 0;
        }
    }
}
