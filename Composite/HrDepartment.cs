using System;

namespace Composite
{
    public class HrDepartment : Company
    {
        public HrDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
        }

        public override void Remove(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司员工招聘培训管理", name);
        }
    }
}
