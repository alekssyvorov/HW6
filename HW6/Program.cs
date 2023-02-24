using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Program
    {
        static int SumTo(int a)
        {
            if (a == 1)
                return 1;
            else
                return a + SumTo(a-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumTo(9));
            Console.ReadLine();
        }
    }
}
