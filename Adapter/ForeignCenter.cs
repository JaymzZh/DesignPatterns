using System;

namespace Adapter
{
    public class ForeignCenter
    {
        public string Name { get; set; }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻", Name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守", Name);
        }
    }
}
