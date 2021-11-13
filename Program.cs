using System;
using System.Collections.Generic;
namespace GenericDelegatesVS2019SAMPLE3
{
    public delegate T AddDelegate<T>(T arg1, T arg2);
    class Program
    {
        private static AddDelegate<double> sub;

        static void Main()
        {
            int a = 30;
            int b = 50;
            AddDelegate<int> del = AddDelegate;
            Console.WriteLine(del(30, 50));
            AddDelegate<double> del2 = Sub;
            Console.WriteLine(del2(1.9f, 1.4f));
            AddDelegate<int> del3 = new AddDelegate<int>((int n1, int n2) => n1 * n2);
            Console.WriteLine(del3(9, 5));
        }
        static int Add(int x, int y)=>x+y;
        static double Sub(double x, double y) => x - y;
        private static int AddDelegate(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}
