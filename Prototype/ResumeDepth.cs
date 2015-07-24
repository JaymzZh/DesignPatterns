using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ResumeDepth : ICloneable
    {
        private string name;
        public int sex, age;

        private WorkExperienceDepth work;

        public ResumeDepth(string name)
        {
            this.name = name;
            work = new WorkExperienceDepth();;
        }

        public ResumeDepth(WorkExperienceDepth work)
        {
            this.work = (WorkExperienceDepth)work.Clone();
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
            return new ResumeDepth(work)
            {
                name = name,
                sex = sex,
                age = age
            };
        }
    }
}
