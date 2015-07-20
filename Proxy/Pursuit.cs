using System;

namespace Proxy
{
    public class Pursuit : IGiveGift
    {
        private readonly SchoolGirl _mm;

        public Pursuit(SchoolGirl mm)
        {
            this._mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine("{0}送你娃娃！", _mm.Name);
        }

        public void GiveFlowers()
        {
            Console.WriteLine("{0}送你洋鲜花！", _mm.Name);
        }

        public void GiveChocolate()
        {
            Console.WriteLine("{0}送你巧克力！", _mm.Name);
        }
    }
}
