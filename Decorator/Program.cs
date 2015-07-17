using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("小明");
            p.Show();
            Console.WriteLine();

            TShirts ts = new TShirts();
            ts.Decorate(p);
            ts.Show();

            BigTrouser dt = new BigTrouser();
            dt.Show();
            Console.WriteLine();
            dt.Decorate(p);
            dt.Show();

            dt.Decorate(ts);
            dt.Show();
        }
    }
}
