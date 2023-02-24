using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "5";
            string b = "1";

            Console.WriteLine(Add(a, b));

            Console.ReadLine();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static string Add(string a, string b)
        {
            return a + b;
        }
    }
}
