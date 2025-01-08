using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciExcersice
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Fibionacci logics; 0,1, 1, 2, 3, 5, 8, 13, 21, 34 etc.
            int n;
            Console.WriteLine("Fibonacci Generation");
            Console.WriteLine("type number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series : ");
            int a = 0, b = 1, c;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a} ");
                c = a + b;
                a = b;
                b = c;
            }

                Console.ReadKey();
            }
        }
    }

