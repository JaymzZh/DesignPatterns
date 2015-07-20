using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl {Name = "李娇娇"};

            Proxy proxy = new Proxy(jiaojiao);

            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();

            Console.Read();
        }
    }
}
