using System;

namespace Constructors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test(100);
            test.Add(100);
            test.Remove(20);
            Console.WriteLine(test.GetValue());
        }
    }

    class Test
    {
        private int _x;

        public Test()
        {
            _x = 0;
        }
        
        public Test(int x)
        {
            this._x = x;
        }
        
        public void Add(int y)
        {
            _x += y;
        }

        public int GetValue()
        {
            return _x;
        }

        public void Remove(int y)
        {
            _x -= y;
        }
    }
}