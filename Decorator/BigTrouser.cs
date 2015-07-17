using System;

namespace Decorator
{
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }
}
