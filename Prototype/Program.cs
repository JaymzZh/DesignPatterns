using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo(1, 30);
            a.SetWorkExperience("2000-2006", "XX公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2003-2005", "YY公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo(2, 25);
            c.SetWorkExperience("2013-2016", "ZZ公司");

            a.Display();
            b.Display();
            c.Display();

            ResumeDepth a1 = new ResumeDepth("大鸟");
            a1.SetPersonalInfo(1, 30);
            a1.SetWorkExperience("2000-2006", "XX公司");

            ResumeDepth b1 = (ResumeDepth)a1.Clone();
            b1.SetWorkExperience("2003-2005", "YY公司");

            ResumeDepth c1 = (ResumeDepth)a1.Clone();
            c1.SetPersonalInfo(2, 25);
            c1.SetWorkExperience("2013-2016", "ZZ公司");

            a1.Display();
            b1.Display();
            c1.Display();


            Console.Read();
        }
    }
}
