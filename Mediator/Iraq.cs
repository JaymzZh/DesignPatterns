using System;

namespace Mediator
{
    public class Iraq : Country
    {
        public Iraq(UniteNations mediator) : base(mediator)
        {
        }
        
        public override void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方信息：{0}", message);
        }
    }
}
