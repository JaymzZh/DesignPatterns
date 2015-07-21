using System;

namespace FactoryMethod
{
    public class OperaDiv : Operate
    {
        public override double GetResult()
        {
            if(0 == NumRight)
                throw new ArgumentException("被除数不能为0！");
            return NumLeft/NumRight;
        }
    }
}
