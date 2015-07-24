using System;

namespace Prototype
{
    public class Resume : ICloneable
    {
        private string name;
        public int sex, age;

        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        public void SetPersonalInfo(int sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
