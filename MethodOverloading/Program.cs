using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            //calls int version of Add()
            Console.WriteLine(Add(10, 10));

            //calls double version of Add()
            Console.WriteLine(Add(4.3, 4.4));

            //Calls long version, using new digit separator
            Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
            
        }

        //Overloaded Add() method
        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static long Add(long x, long y)
        {
            return x + y;
        }

        static int AddWrapper(int x, int y)
        {
            return Add();

            int Add()
            {
                return x + y;
            }
        }
    }
}
