using System;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        public ConcreteSubject Subject { get; set; }

        private string name;
        private string observerState;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.Subject = subject;
        }

        public override void Update()
        {
            observerState = Subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }
    }
}
