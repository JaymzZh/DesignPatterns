using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaper t = new TestPaperA();
            t.TestQuestion1();

            t = new TestPaperB();
            t.TestQuestion1();

            Console.Read();
        }
    }
}
