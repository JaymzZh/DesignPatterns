using System;

namespace AbstractFactory
{
    public class SqlserverUser :IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SqlServer中给User插入了一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SqlServer中根据Id得到了一条记录");
            return null;
        }
    }
}
