using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---简单计算器---");
            Console.Write("请输入左值：");
            string numLeftStr = Console.ReadLine();
            Console.WriteLine();
            Console.Write("请输入运算符：");
            string oper = Console.ReadLine();
            Console.WriteLine();
            Console.Write("请输入右值：");
            string numRightStr = Console.ReadLine();
            double numLeft = 0, numRight = 0;
            double.TryParse(numLeftStr, out numLeft);
            double.TryParse(numRightStr, out numRight);
            IFactory operFactory;
            switch (oper)
            {
                case "+":
                    operFactory = new AddFactory();
                    break;
                case "-":
                    operFactory = new SubFactory();
                    break;
                case "*":
                    operFactory = new MulFactory();
                    break;
                case "/":
                    operFactory = new DivFactory();
                    break;
                default:
                    operFactory = new AddFactory();
                    break;

            }
            Operate op = operFactory.CreateOperate();
            op.NumLeft = numLeft;
            op.NumRight = numRight;
            Console.WriteLine("结果为{0}", op.GetResult());
        }
    }
}
