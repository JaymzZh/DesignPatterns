using System;

namespace Mediator
{
    public class USA : Country
    {
        public USA(UniteNations mediator) : base(mediator)
        {
        }

        public override void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方信息：{0}", message);
        }
    }
}
