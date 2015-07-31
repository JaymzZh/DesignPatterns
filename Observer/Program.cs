namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            Observer observer = new ConcreteObserver("张三", subject);
            subject.Attach(observer);
            subject.SubjectState = "老板回来了";
            subject.Notify();
        }
    }
}
