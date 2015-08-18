using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "大鸟";
            a[1] = "大鸟1";
            a[2] = "大鸟2";
            a[3] = "大鸟3";
            a[4] = "大鸟4";
            a[5] = "大鸟5";

            Iterator i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买票！", i.CurrentItem());
                i.Next();
            }

            Console.Read();
        }
    }
}
