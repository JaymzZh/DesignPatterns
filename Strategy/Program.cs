using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext context = new CashContext("正常收费");
            Console.WriteLine(context.GetResult(600));
            context = new CashContext("打8折");
            Console.WriteLine(context.GetResult(600));
            context = new CashContext("满300减100");
            Console.WriteLine(context.GetResult(600));
        }
    }
}
