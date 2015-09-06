using System;

namespace Flyweight
{
    public class ConcreteWebSite : WebSite
    {
        private string name = string.Empty;

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：{0} 用户：{1}", name, user.Name);
        }
    }
}
