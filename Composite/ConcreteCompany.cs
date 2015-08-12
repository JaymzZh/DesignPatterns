using System;
using System.Collections.Generic;

namespace Composite
{
    public class ConcreteCompany : Company
    {
        private List<Company>  children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var company in children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var company in children)
            {
                company.LineOfDuty();
            }
        }
    }
}
