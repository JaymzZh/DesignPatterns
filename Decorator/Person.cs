using System;

namespace Decorator
{
    public class Person
    {
        public Person()
        {
            
        }

        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
}
