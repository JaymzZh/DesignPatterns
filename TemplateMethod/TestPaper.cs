using System;

namespace TemplateMethod
{
    public abstract class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("问题1：XXXXXXXXXX");
            Console.WriteLine("答案：" + Answer1());
        }

        public virtual string Answer1()
        {
            return String.Empty;
        }
    }
}
