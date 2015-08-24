using System;
using System.Collections.Generic;
using System.Globalization;

namespace Command
{
    public class Waiter
    {
        private IList<Command> orders = new List<Command>();

        public void SetOrder(Command command)
        {
            if (command.ToString() == "Command.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：{0} 时间：{1}", command, DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：{0} 时间：{1}", command, DateTime.Now.ToString(CultureInfo.InvariantCulture));
        }

        public void Notify()
        {
            foreach (Command command in orders)
            {
                command.ExecuteCommand();
            }
        }
    }
}
