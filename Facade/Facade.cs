using System;

namespace Facade
{
    public class Facade
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;
        private SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n方法组A() ---- ");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("\n方法组B() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
    }
}
