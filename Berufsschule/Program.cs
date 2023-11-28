using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berufsschule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(10);
            Console.WriteLine(t.test(5));
            Console.WriteLine(t.hallo);
        }
    }

    class Test
    {
        public int hallo = 5;

        public Test()
        {
        }

        public Test(int k) : this()
        {
            hallo += k;
        }
        
        public int test(int x)
        {
            return x;
        }
    }
}
