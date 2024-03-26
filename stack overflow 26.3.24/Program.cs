using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_overflow_26._3._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (e.g. '5'): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nFact: {FactorialCalc(n)}");
            Console.WriteLine($"\nFib: {Fibonacci(n)}");
            
            Console.Write("\nEnter any string: ");
            string s = Console.ReadLine();
            Console.Write($"\nPalindrome? {PalCheck(s)}");
            Console.ReadLine();
        }
        static int FactorialCalc(int n)
        {
           if(n == 1)
           {
                return 1;
           }
           else
           {
                return n * FactorialCalc(n - 1);
           }

        }
        static int Fibonacci(int n)
        {
            if(n < 3)
            {
                return 1;
            }
            else 
            {
                return n = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static bool PalCheck(string s)
        {
            if(s.Length < 2)
            {
                return true;
            }
            if (s[0] != s[s.Length - 1])
            {
                return false;
                
            }
            return PalCheck(s.Substring(1, s.Length - 2));

        } 
    }
}
