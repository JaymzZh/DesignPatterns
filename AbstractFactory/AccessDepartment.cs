using System;

namespace AbstractFactory
{
    public class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给department表增加了一条记录。");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中给根据id得到department表一条记录。");
            return null;
        }
    }
}
