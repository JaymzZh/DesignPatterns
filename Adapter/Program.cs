using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴奈尔");
            b.Attack();

            Player m = new Guards("麦克格雷迪");
            m.Attack();

            Player y = new Translator("姚明");
            y.Attack();
            y.Defense();

            Console.Read();
        }
    }
}
